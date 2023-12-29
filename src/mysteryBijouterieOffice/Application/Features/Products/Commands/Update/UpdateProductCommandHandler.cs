using Application.Features.Products.Rules;
using Application.Services.ProductMaterialsService;
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
    private readonly IProductMaterialService _productMaterialService;

    public UpdateProductCommandHandler(
        IProductRepository productRepository,
        IMapper mapper,
        ProductBusinessRules productBusinessRules,
        IProductMaterialService productMaterialService
    )
    {
        _productRepository = productRepository;
        _mapper = mapper;
        _productBusinessRules = productBusinessRules;
        _productMaterialService = productMaterialService;
    }

    public async Task<UpdatedProductResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        Product? product = await _productRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);

        await _productBusinessRules.ProductShouldExistWhenSelected(product);
        await _productBusinessRules.ProductBarcodeNumberCanNotBeDuplicatedWhenUpdated(request.Id, request.BarcodeNumber);
        await _productBusinessRules.ProductStockCodeNotBeDuplicatedWhenUpdated(request.Id, request.StockCode);

        _mapper.Map(request, product);

        await _productMaterialService.DeleteAllByProductId(request.Id, cancellationToken);

        Product updatedProduct = await _productRepository.UpdateAsync(product!);
        UpdatedProductResponse response = _mapper.Map<UpdatedProductResponse>(updatedProduct);
        return response;
    }
}
