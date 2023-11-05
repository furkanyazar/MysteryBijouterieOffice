using Core.Application.Dtos;

namespace Application.Features.Products.Queries.GetListByDynamic;

public class GetListByDynamicProductListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public GetListByDynamicProductListItemDto()
    {
        Name = string.Empty;
    }

    public GetListByDynamicProductListItemDto(int id, string name, string? barcodeNumber, decimal unitPrice)
    {
        Id = id;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}
