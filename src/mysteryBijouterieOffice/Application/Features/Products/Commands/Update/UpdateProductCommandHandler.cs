using Application.Features.Products.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Commands.Update;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdatedProductResponse>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    private readonly ProductBusinessRules _productBusinessRules;

    public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper, ProductBusinessRules productBusinessRules)
    {
        _productRepository = productRepository;
        _mapper = mapper;
        _productBusinessRules = productBusinessRules;
    }

    public async Task<UpdatedProductResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        Product? product = await _productRepository.GetAsync(p => p.Id == request.Id, cancellationToken: cancellationToken);

        await _productBusinessRules.ProductShouldExistWhenSelected(product);
        await _productBusinessRules.ProductBarcodeNumberCanNotBeDuplicatedWhenUpdated(request.Id, request.BarcodeNumber);

        _mapper.Map(request, product);

        Product updatedProduct = await _productRepository.UpdateAsync(product!);
        UpdatedProductResponse response = _mapper.Map<UpdatedProductResponse>(updatedProduct);
        return response;
    }
}
