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
    public int UnitsInStock { get; set; }
    public string? StockCode { get; set; }

    public virtual Category? Category { get; set; }
    public virtual ICollection<ProductMaterial> ProductMaterials { get; set; } = null!;

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
        int unitsInStock,
        string? stockCode
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
        UnitsInStock = unitsInStock;
        StockCode = stockCode;
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
        int unitsInStock,
        string? stockCode
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
        UnitsInStock = unitsInStock;
        StockCode = stockCode;
    }
}
