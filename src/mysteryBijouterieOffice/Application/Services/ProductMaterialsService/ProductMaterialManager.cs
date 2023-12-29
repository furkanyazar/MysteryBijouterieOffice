using Application.Services.Repositories;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Services.ProductMaterialsService;

public class ProductMaterialManager : IProductMaterialService
{
    private readonly IProductMaterialRepository _productMaterialRepository;

    public ProductMaterialManager(IProductMaterialRepository productMaterialRepository)
    {
        _productMaterialRepository = productMaterialRepository;
    }

    public async Task DeleteAllByProductId(int productId, CancellationToken cancellationToken = default)
    {
        IPaginate<ProductMaterial> productMaterials = await _productMaterialRepository.GetListAsync(
            predicate: pm => pm.ProductId == productId,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await _productMaterialRepository.DeleteRangeAsync(productMaterials.Items, permanent: true);
    }
}
