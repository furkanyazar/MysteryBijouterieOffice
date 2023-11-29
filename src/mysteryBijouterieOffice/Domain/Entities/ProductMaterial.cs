using Core.Persistence.Repositories;

namespace Domain.Entities;

public class ProductMaterial : Entity<int>
{
    public int ProductId { get; set; }
    public int MaterialId { get; set; }

    public virtual Product Product { get; set; } = null!;
    public virtual Material Material { get; set; } = null!;

    public ProductMaterial() { }

    public ProductMaterial(int productId, int materialId)
    {
        ProductId = productId;
        MaterialId = materialId;
    }

    public ProductMaterial(int id, int productId, int materialId)
        : base(id)
    {
        ProductId = productId;
        MaterialId = materialId;
    }
}
