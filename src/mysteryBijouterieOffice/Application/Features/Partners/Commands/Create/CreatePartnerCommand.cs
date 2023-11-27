using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Partners.Commands.Create;

public class CreatePartnerCommand : IRequest<CreatedPartnerResponse>, ISecuredRequest
{
    public string Name { get; set; }
    public decimal ShippingCost { get; set; }
    public decimal ServiceFee { get; set; }
    public bool HasFirstScale { get; set; }
    public bool HasSecondScale { get; set; }
    public decimal? FirstScaleLowerLimit { get; set; }
    public decimal? FirstScaleUpperLimit { get; set; }
    public decimal? SecondScaleLowerLimit { get; set; }
    public decimal? SecondScaleUpperLimit { get; set; }
    public decimal? FirstScaleShippingFee { get; set; }
    public decimal? SecondScaleShippingFee { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public CreatePartnerCommand()
    {
        Name = string.Empty;
    }

    public CreatePartnerCommand(
        string name,
        decimal shippingCost,
        decimal serviceFee,
        bool hasFirstScale,
        bool hasSecondScale,
        decimal? firstScaleLowerLimit,
        decimal? firstScaleUpperLimit,
        decimal? secondScaleLowerLimit,
        decimal? secondScaleUpperLimit,
        decimal? firstScaleShippingFee,
        decimal? secondScaleShippingFee
    )
    {
        Name = name;
        ShippingCost = shippingCost;
        ServiceFee = serviceFee;
        HasFirstScale = hasFirstScale;
        HasSecondScale = hasSecondScale;
        FirstScaleLowerLimit = firstScaleLowerLimit;
        FirstScaleUpperLimit = firstScaleUpperLimit;
        SecondScaleLowerLimit = secondScaleLowerLimit;
        SecondScaleUpperLimit = secondScaleUpperLimit;
        FirstScaleShippingFee = firstScaleShippingFee;
        SecondScaleShippingFee = secondScaleShippingFee;
    }
}
