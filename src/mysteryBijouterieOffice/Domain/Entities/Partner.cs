using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Partner : Entity<int>
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

    public virtual ICollection<CategoryPartner> CategoryPartners { get; set; } = null!;

    public Partner()
    {
        Name = string.Empty;
    }

    public Partner(
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

    public Partner(
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
        : base(id)
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
