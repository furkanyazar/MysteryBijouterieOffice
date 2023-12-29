using Core.Application.Responses;

namespace Application.Features.Materials.Commands.Create;

public class CreatedMaterialResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal PurchasePrice { get; set; }
    public int UnitsInStock { get; set; }

    public CreatedMaterialResponse()
    {
        Name = string.Empty;
    }

    public CreatedMaterialResponse(int id, string name, decimal purchasePrice, int unitsInStock)
    {
        Id = id;
        Name = name;
        PurchasePrice = purchasePrice;
        UnitsInStock = unitsInStock;
    }
}
