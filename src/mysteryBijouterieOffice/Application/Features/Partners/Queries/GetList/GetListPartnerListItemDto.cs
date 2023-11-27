using Core.Application.Dtos;

namespace Application.Features.Partners.Queries.GetList;

public class GetListPartnerListItemDto : IDto
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

    public GetListPartnerListItemDto()
    {
        Name = string.Empty;
    }

    public GetListPartnerListItemDto(
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
