using Core.Application.Responses;

namespace Application.Features.Products.Commands.Create;

public class CreatedProductResponse : IResponse
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public string CategoryName { get; set; }
    public string ModelNumber { get; set; }

    public CreatedProductResponse()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        CategoryName = string.Empty;
        ModelNumber = string.Empty;
    }

    public CreatedProductResponse(
        int id,
        int categoryId,
        string name,
        string barcodeNumber,
        decimal unitPrice,
        string categoryName,
        string modelNumber
    )
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
        CategoryName = categoryName;
        ModelNumber = modelNumber;
    }
}
