using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Product : Entity<int>
{
    public int? CategoryId { get; set; }
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SalePrice { get; set; }
    public string ModelNumber { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }

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
        decimal purchasePrice,
        decimal salePrice,
        string modelNumber,
        string? imageUrl,
        string? description,
        bool status
    )
    {
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        PurchasePrice = purchasePrice;
        SalePrice = salePrice;
        ModelNumber = modelNumber;
        ImageUrl = imageUrl;
        Description = description;
        Status = status;
    }

    public Product(
        int id,
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal purchasePrice,
        decimal salePrice,
        string modelNumber,
        string? imageUrl,
        string? description,
        bool status
    )
        : base(id)
    {
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        PurchasePrice = purchasePrice;
        SalePrice = salePrice;
        ModelNumber = modelNumber;
        ImageUrl = imageUrl;
        Description = description;
        Status = status;
    }
}
