using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Partners.Commands.Create;

public class CreatePartnerCommand : IRequest<CreatedPartnerResponse>, ISecuredRequest
{
    public string Name { get; set; }
    public decimal ShippingCost { get; set; }
    public bool HasFreeShipping { get; set; }
    public decimal FreeShippingLowerLimit { get; set; }
    public decimal ServiceFee { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public CreatePartnerCommand()
    {
        Name = string.Empty;
    }

    public CreatePartnerCommand(string name, decimal shippingCost, bool hasFreeShipping, decimal freeShippingLowerLimit, decimal serviceFee)
    {
        Name = name;
        ShippingCost = shippingCost;
        HasFreeShipping = hasFreeShipping;
        FreeShippingLowerLimit = freeShippingLowerLimit;
        ServiceFee = serviceFee;
    }
}
