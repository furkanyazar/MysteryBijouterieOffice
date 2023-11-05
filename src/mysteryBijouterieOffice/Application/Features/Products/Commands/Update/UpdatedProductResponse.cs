using Core.Application.Responses;

namespace Application.Features.Products.Commands.Update;

public class UpdatedProductResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public UpdatedProductResponse()
    {
        Name = string.Empty;
    }

    public UpdatedProductResponse(int id, string name, string? barcodeNumber, decimal unitPrice)
    {
        Id = id;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}
