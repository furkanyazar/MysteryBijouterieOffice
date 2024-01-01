using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Discounts.Commands.Update;

public class UpdateDiscountCommand : IRequest<UpdatedDiscountResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public string Name { get; set; }
    public int DiscountType { get; set; }
    public decimal DiscountAmount { get; set; }

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public UpdateDiscountCommand()
    {
        Name = string.Empty;
    }

    public UpdateDiscountCommand(int id, int partnerId, string name, int discountType, decimal discountAmount)
    {
        Id = id;
        PartnerId = partnerId;
        Name = name;
        DiscountType = discountType;
        DiscountAmount = discountAmount;
    }
}
