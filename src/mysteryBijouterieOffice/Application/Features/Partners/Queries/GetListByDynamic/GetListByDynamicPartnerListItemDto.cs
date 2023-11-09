using Core.Application.Dtos;

namespace Application.Features.Partners.Queries.GetListByDynamic;

public class GetListByDynamicPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal ShippingCost { get; set; }
    public bool HasFreeShipping { get; set; }
    public decimal FreeShippingLowerLimit { get; set; }

    public GetListByDynamicPartnerListItemDto()
    {
        Name = string.Empty;
    }

    public GetListByDynamicPartnerListItemDto(
        int id,
        string name,
        decimal shippingCost,
        bool hasFreeShipping,
        decimal freeShippingLowerLimit
    )
    {
        Id = id;
        Name = name;
        ShippingCost = shippingCost;
        HasFreeShipping = hasFreeShipping;
        FreeShippingLowerLimit = freeShippingLowerLimit;
    }
}
