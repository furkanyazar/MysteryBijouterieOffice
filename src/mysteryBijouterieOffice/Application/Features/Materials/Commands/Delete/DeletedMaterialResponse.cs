using Core.Application.Responses;

namespace Application.Features.Materials.Commands.Delete;

public class DeletedMaterialResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal PurchasePrice { get; set; }
    public int UnitsInStock { get; set; }

    public DeletedMaterialResponse()
    {
        Name = string.Empty;
    }

    public DeletedMaterialResponse(int id, string name, decimal purchasePrice, int unitsInStock)
    {
        Id = id;
        Name = name;
        PurchasePrice = purchasePrice;
        UnitsInStock = unitsInStock;
    }
}
