using Core.Application.Responses;

namespace Application.Features.Products.Commands.Delete;

public class DeletedProductResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public DeletedProductResponse()
    {
        Name = string.Empty;
    }

    public DeletedProductResponse(int id, string name, string? barcodeNumber, decimal unitPrice)
    {
        Id = id;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}
