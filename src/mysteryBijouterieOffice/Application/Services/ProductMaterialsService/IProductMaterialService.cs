namespace Application.Services.ProductMaterialsService;

public interface IProductMaterialService
{
    public Task DeleteAllByProductId(int productId, CancellationToken cancellationToken = default);
}
