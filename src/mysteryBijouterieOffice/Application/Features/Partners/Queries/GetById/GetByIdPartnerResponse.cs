using Core.Application.Responses;

namespace Application.Features.Partners.Queries.GetById;

public class GetByIdPartnerResponse : IResponse
{
    public int Id { get; set; }
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

    public GetByIdPartnerResponse()
    {
        Name = string.Empty;
    }

    public GetByIdPartnerResponse(
        int id,
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
        Id = id;
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
