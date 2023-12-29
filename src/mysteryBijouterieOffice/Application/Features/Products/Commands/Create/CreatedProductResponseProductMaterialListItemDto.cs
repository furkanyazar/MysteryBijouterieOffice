using Core.Application.Dtos;

namespace Application.Features.Products.Commands.Create;

public class CreatedProductResponseProductMaterialListItemDto : IDto
{
    public int Id { get; set; }
    public int MaterialId { get; set; }
    public string MaterialName { get; set; }
    public decimal MaterialPurchasePrice { get; set; }
    public int MaterialUnitsInStock { get; set; }

    public CreatedProductResponseProductMaterialListItemDto()
    {
        MaterialName = string.Empty;
    }

    public CreatedProductResponseProductMaterialListItemDto(
        int id,
        int materialId,
        string materialName,
        decimal materialPurchasePrice,
        int materialUnitsInStock
    )
    {
        Id = id;
        MaterialId = materialId;
        MaterialName = materialName;
        MaterialPurchasePrice = materialPurchasePrice;
        MaterialUnitsInStock = materialUnitsInStock;
    }
}
