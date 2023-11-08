using Core.Application.Dtos;

namespace Application.Features.Categories.Queries.GetListByDynamic;

public class GetListByDynamicCategoryCategoryPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public double CommissionRate { get; set; }
    public string PartnerName { get; set; }

    public GetListByDynamicCategoryCategoryPartnerListItemDto()
    {
        PartnerName = string.Empty;
    }

    public GetListByDynamicCategoryCategoryPartnerListItemDto(int id, int partnerId, double commissionRate, string partnerName)
    {
        Id = id;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
        PartnerName = partnerName;
    }
}
