using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Partners.Commands.Update;

public class UpdatePartnerCommand : IRequest<UpdatedPartnerResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal ShippingCost { get; set; }
    public decimal ServiceFee { get; set; }
    public bool HasShippingScale { get; set; }
    public decimal? FirstScaleLowerLimit { get; set; }
    public decimal? FirstScaleUpperLimit { get; set; }
    public decimal? SecondScaleLowerLimit { get; set; }
    public decimal? SecondScaleUpperLimit { get; set; }
    public decimal? FirstScaleShippingFee { get; set; }
    public decimal? SecondScaleShippingFee { get; set; }
    public decimal TransactionFee { get; set; }
    public bool HasTaxShippingCost { get; set; }
    public bool HasTaxServiceFee { get; set; }
    public bool HasTaxTransactionFee { get; set; }
    public bool HasTaxCommissions { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public UpdatePartnerCommand()
    {
        Name = string.Empty;
    }

    public UpdatePartnerCommand(
        int id,
        string name,
        decimal shippingCost,
        decimal serviceFee,
        bool hasShippingScale,
        decimal? firstScaleLowerLimit,
        decimal? firstScaleUpperLimit,
        decimal? secondScaleLowerLimit,
        decimal? secondScaleUpperLimit,
        decimal? firstScaleShippingFee,
        decimal? secondScaleShippingFee,
        decimal transactionFee,
        bool hasTaxShippingCost,
        bool hasTaxServiceFee,
        bool hasTaxTransactionFee,
        bool hasTaxCommissions
    )
    {
        Id = id;
        Name = name;
        ShippingCost = shippingCost;
        ServiceFee = serviceFee;
        HasShippingScale = hasShippingScale;
        FirstScaleLowerLimit = firstScaleLowerLimit;
        FirstScaleUpperLimit = firstScaleUpperLimit;
        SecondScaleLowerLimit = secondScaleLowerLimit;
        SecondScaleUpperLimit = secondScaleUpperLimit;
        FirstScaleShippingFee = firstScaleShippingFee;
        SecondScaleShippingFee = secondScaleShippingFee;
        TransactionFee = transactionFee;
        HasTaxShippingCost = hasTaxShippingCost;
        HasTaxServiceFee = hasTaxServiceFee;
        HasTaxTransactionFee = hasTaxTransactionFee;
        HasTaxCommissions = hasTaxCommissions;
    }
}
