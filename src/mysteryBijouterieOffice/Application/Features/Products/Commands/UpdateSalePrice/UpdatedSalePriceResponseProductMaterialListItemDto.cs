using Core.Application.Dtos;

namespace Application.Features.Products.Commands.UpdateSalePrice;

public class UpdatedSalePriceResponseProductMaterialListItemDto : IDto
{
    public int Id { get; set; }
    public int MaterialId { get; set; }
    public string MaterialName { get; set; }
    public decimal MaterialPurchasePrice { get; set; }
    public int MaterialUnitsInStock { get; set; }

    public UpdatedSalePriceResponseProductMaterialListItemDto()
    {
        MaterialName = string.Empty;
    }

    public UpdatedSalePriceResponseProductMaterialListItemDto(
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
