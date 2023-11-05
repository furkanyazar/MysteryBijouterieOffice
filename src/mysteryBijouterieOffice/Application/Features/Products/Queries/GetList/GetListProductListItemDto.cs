using Core.Application.Dtos;

namespace Application.Features.Products.Queries.GetList;

public class GetListProductListItemDto : IDto
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public string CategoryName { get; set; }

    public GetListProductListItemDto()
    {
        Name = string.Empty;
        CategoryName = string.Empty;
    }

    public GetListProductListItemDto(int id, int categoryId, string name, string? barcodeNumber, decimal unitPrice, string categoryName)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
        CategoryName = categoryName;
    }
}
