using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Materials.Commands.Create;

public class CreateMaterialCommand : IRequest<CreatedMaterialResponse>, ISecuredRequest
{
    public string Name { get; set; }
    public decimal PurchasePrice { get; set; }
    public int UnitsInStock { get; set; }

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public CreateMaterialCommand()
    {
        Name = string.Empty;
    }

    public CreateMaterialCommand(string name, decimal purchasePrice, int unitsInStock)
    {
        Name = name;
        PurchasePrice = purchasePrice;
        UnitsInStock = unitsInStock;
    }
}
