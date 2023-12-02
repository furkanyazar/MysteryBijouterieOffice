using Core.Application.Dtos;

namespace Application.Features.Products.Queries.GetListByDynamic;

public class GetListByDynamicProductProductMaterialListItemDto : IDto
{
    public int Id { get; set; }
    public int MaterialId { get; set; }
    public string MaterialName { get; set; }
    public decimal MaterialPurchasePrice { get; set; }
    public int MaterialUnitsInStock { get; set; }

    public GetListByDynamicProductProductMaterialListItemDto()
    {
        MaterialName = string.Empty;
    }

    public GetListByDynamicProductProductMaterialListItemDto(
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
