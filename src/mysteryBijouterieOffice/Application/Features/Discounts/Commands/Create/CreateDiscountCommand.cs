using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Discounts.Commands.Create;

public class CreateDiscountCommand : IRequest<CreatedDiscountResponse>, ISecuredRequest
{
    public int PartnerId { get; set; }
    public string Name { get; set; }
    public int DiscountType { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal DiscountLowerLimit { get; set; }
    public int Priority { get; set; }

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public CreateDiscountCommand()
    {
        Name = string.Empty;
    }

    public CreateDiscountCommand(
        int partnerId,
        string name,
        int discountType,
        decimal discountAmount,
        decimal discountLowerLimit,
        int priority
    )
    {
        PartnerId = partnerId;
        Name = name;
        DiscountType = discountType;
        DiscountAmount = discountAmount;
        DiscountLowerLimit = discountLowerLimit;
        Priority = priority;
    }
}
