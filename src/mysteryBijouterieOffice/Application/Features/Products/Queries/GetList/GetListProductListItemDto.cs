using Core.Application.Dtos;

namespace Application.Features.Products.Queries.GetList;

public class GetListProductListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public GetListProductListItemDto()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
    }

    public GetListProductListItemDto(int id, string name, string barcodeNumber, decimal unitPrice)
    {
        Id = id;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}
