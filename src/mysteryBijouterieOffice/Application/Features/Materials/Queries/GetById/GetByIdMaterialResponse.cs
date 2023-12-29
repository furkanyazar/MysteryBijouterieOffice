using Core.Application.Responses;

namespace Application.Features.Materials.Queries.GetById;

public class GetByIdMaterialResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal PurchasePrice { get; set; }
    public int UnitsInStock { get; set; }

    public GetByIdMaterialResponse()
    {
        Name = string.Empty;
    }

    public GetByIdMaterialResponse(int id, string name, decimal purchasePrice, int unitsInStock)
    {
        Id = id;
        Name = name;
        PurchasePrice = purchasePrice;
        UnitsInStock = unitsInStock;
    }
}
