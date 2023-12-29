using Application.Features.Products.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Commands.UpdateSalePrice;

public class UpdateSalePriceCommandHandler : IRequestHandler<UpdateSalePriceCommand, UpdatedSalePriceResponse>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    private readonly ProductBusinessRules _productBusinessRules;

    public UpdateSalePriceCommandHandler(IProductRepository productRepository, IMapper mapper, ProductBusinessRules productBusinessRules)
    {
        _productRepository = productRepository;
        _mapper = mapper;
        _productBusinessRules = productBusinessRules;
    }

    public async Task<UpdatedSalePriceResponse> Handle(UpdateSalePriceCommand request, CancellationToken cancellationToken)
    {
        Product? product = await _productRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);

        await _productBusinessRules.ProductShouldExistWhenSelected(product);

        _mapper.Map(request, product);

        Product updatedProduct = await _productRepository.UpdateAsync(product!);
        UpdatedSalePriceResponse response = _mapper.Map<UpdatedSalePriceResponse>(updatedProduct);
        return response;
    }
}
