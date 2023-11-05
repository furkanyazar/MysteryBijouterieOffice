using Core.Application.Dtos;

namespace Application.Features.Products.Queries.GetListByDynamic;

public class GetListByDynamicProductListItemDto : IDto
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public string CategoryName { get; set; }

    public GetListByDynamicProductListItemDto()
    {
        Name = string.Empty;
        CategoryName = string.Empty;
    }

    public GetListByDynamicProductListItemDto(
        int id,
        int categoryId,
        string name,
        string? barcodeNumber,
        decimal unitPrice,
        string categoryName
    )
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
        CategoryName = categoryName;
    }
}
