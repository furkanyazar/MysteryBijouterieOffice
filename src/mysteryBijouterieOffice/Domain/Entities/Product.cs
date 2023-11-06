using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Product : Entity<int>
{
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public Product()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
    }

    public Product(string name, string barcodeNumber, decimal unitPrice)
    {
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }

    public Product(int id, string name, string barcodeNumber, decimal unitPrice)
        : base(id)
    {
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}
