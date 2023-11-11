using Core.Application.Dtos;

namespace Application.Features.Partners.Queries.GetList;

public class GetListPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal ShippingCost { get; set; }
    public bool HasFreeShipping { get; set; }
    public decimal FreeShippingLowerLimit { get; set; }
    public decimal ServiceFee { get; set; }

    public GetListPartnerListItemDto()
    {
        Name = string.Empty;
    }

    public GetListPartnerListItemDto(
        int id,
        string name,
        decimal shippingCost,
        bool hasFreeShipping,
        decimal freeShippingLowerLimit,
        decimal serviceFee
    )
    {
        Id = id;
        Name = name;
        ShippingCost = shippingCost;
        HasFreeShipping = hasFreeShipping;
        FreeShippingLowerLimit = freeShippingLowerLimit;
        ServiceFee = serviceFee;
    }
}
