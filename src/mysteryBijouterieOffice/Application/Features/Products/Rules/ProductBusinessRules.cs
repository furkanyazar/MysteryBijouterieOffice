using Application.Features.Products.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Products.Rules;

public class ProductBusinessRules : BaseBusinessRules
{
    private readonly IProductRepository _productRepository;

    public ProductBusinessRules(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task ProductShouldExistWhenSelected(Product? product)
    {
        if (product is null)
            throw new NotFoundException(ProductsMessages.ProductNotExists);
        return Task.CompletedTask;
    }

    public async Task ProductBarcodeNumberCanNotBeDuplicatedWhenInserted(string barcodeNumber)
    {
        bool doesExists = await _productRepository.AnyAsync(
            predicate: p => p.BarcodeNumber == barcodeNumber,
            withDeleted: true,
            enableTracking: false
        );
        if (doesExists)
            throw new BusinessException(ProductsMessages.ProductBarcodeNumberAlreadyExists);
    }

    public async Task ProductBarcodeNumberCanNotBeDuplicatedWhenUpdated(int id, string barcodeNumber)
    {
        bool doesExists = await _productRepository.AnyAsync(
            predicate: p => p.Id != id && p.BarcodeNumber == barcodeNumber,
            withDeleted: true,
            enableTracking: false
        );
        if (doesExists)
            throw new BusinessException(ProductsMessages.ProductBarcodeNumberAlreadyExists);
    }
}
