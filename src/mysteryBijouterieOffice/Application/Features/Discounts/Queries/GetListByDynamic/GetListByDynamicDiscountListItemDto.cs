using Core.Application.Dtos;

namespace Application.Features.Discounts.Queries.GetListByDynamic;

public class GetListByDynamicDiscountListItemDto : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public string Name { get; set; }
    public int DiscountType { get; set; }
    public decimal DiscountAmount { get; set; }
    public string PartnerName { get; set; }
    public decimal DiscountLowerLimit { get; set; }
    public int Priority { get; set; }

    public GetListByDynamicDiscountListItemDto()
    {
        Name = string.Empty;
        PartnerName = string.Empty;
    }

    public GetListByDynamicDiscountListItemDto(
        int id,
        int partnerId,
        string name,
        int discountType,
        decimal discountAmount,
        string partnerName,
        decimal discountLowerLimit,
        int priority
    )
    {
        Id = id;
        PartnerId = partnerId;
        Name = name;
        DiscountType = discountType;
        DiscountAmount = discountAmount;
        PartnerName = partnerName;
        DiscountLowerLimit = discountLowerLimit;
        Priority = priority;
    }
}
