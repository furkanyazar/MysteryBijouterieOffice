using Core.Application.Dtos;

namespace Application.Features.Materials.Queries.GetListByDynamic;

public class GetListByDynamicMaterialListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal PurchasePrice { get; set; }
    public int UnitsInStock { get; set; }

    public GetListByDynamicMaterialListItemDto()
    {
        Name = string.Empty;
    }

    public GetListByDynamicMaterialListItemDto(int id, string name, decimal purchasePrice, int unitsInStock)
    {
        Id = id;
        Name = name;
        PurchasePrice = purchasePrice;
        UnitsInStock = unitsInStock;
    }
}
