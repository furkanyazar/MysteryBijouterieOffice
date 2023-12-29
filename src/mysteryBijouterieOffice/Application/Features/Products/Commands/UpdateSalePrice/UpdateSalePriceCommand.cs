using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Products.Commands.UpdateSalePrice;

public class UpdateSalePriceCommand : IRequest<UpdatedSalePriceResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public decimal SalePrice { get; set; }

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public UpdateSalePriceCommand() { }

    public UpdateSalePriceCommand(int id, decimal salePrice)
    {
        Id = id;
        SalePrice = salePrice;
    }
}
