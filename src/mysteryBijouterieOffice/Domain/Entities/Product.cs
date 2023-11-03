using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Product : Entity<int>
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public virtual Category Category { get; set; } = null!;

    public Product()
    {
        Name = string.Empty;
    }

    public Product(int categoryId, string name, string? barcodeNumber, decimal unitPrice)
    {
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }

    public Product(int id, int categoryId, string name, string? barcodeNumber, decimal unitPrice)
        : base(id)
    {
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}
