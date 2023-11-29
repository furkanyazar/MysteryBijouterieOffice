using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Materials.Commands.Update;

public class UpdateMaterialCommand : IRequest<UpdatedMaterialResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal PurchasePrice { get; set; }
    public int UnitsInStock { get; set; }

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public UpdateMaterialCommand()
    {
        Name = string.Empty;
    }

    public UpdateMaterialCommand(int id, string name, decimal purchasePrice, int unitsInStock)
    {
        Id = id;
        Name = name;
        PurchasePrice = purchasePrice;
        UnitsInStock = unitsInStock;
    }
}
