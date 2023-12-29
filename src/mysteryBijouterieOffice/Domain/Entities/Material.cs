using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Material : Entity<int>
{
    public string Name { get; set; }
    public decimal PurchasePrice { get; set; }
    public int UnitsInStock { get; set; }

    public virtual ICollection<ProductMaterial> ProductMaterials { get; set; } = null!;

    public Material()
    {
        Name = string.Empty;
    }

    public Material(string name, decimal purchasePrice, int unitsInStock)
    {
        Name = name;
        PurchasePrice = purchasePrice;
        UnitsInStock = unitsInStock;
    }

    public Material(int id, string name, decimal purchasePrice, int unitsInStock)
        : base(id)
    {
        Name = name;
        PurchasePrice = purchasePrice;
        UnitsInStock = unitsInStock;
    }
}
