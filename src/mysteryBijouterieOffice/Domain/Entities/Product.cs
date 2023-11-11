using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Product : Entity<int>
{
    public int? CategoryId { get; set; }
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public string ModelNumber { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }

    public virtual Category? Category { get; set; }

    public Product()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
    }

    public Product(
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal unitPrice,
        string modelNumber,
        string? imageUrl,
        string? description
    )
    {
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
        ModelNumber = modelNumber;
        ImageUrl = imageUrl;
        Description = description;
    }

    public Product(
        int id,
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal unitPrice,
        string modelNumber,
        string? imageUrl,
        string? description
    )
        : base(id)
    {
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
        ModelNumber = modelNumber;
        ImageUrl = imageUrl;
        Description = description;
    }
}
