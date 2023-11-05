using Core.Application.Responses;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public GetByIdProductResponse()
    {
        Name = string.Empty;
    }

    public GetByIdProductResponse(int id, string name, string? barcodeNumber, decimal unitPrice)
    {
        Id = id;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}
