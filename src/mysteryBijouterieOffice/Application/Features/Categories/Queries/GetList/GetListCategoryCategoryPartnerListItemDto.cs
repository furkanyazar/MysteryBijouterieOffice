using Core.Application.Dtos;

namespace Application.Features.Categories.Queries.GetList;

public class GetListCategoryCategoryPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public double CommissionRate { get; set; }
    public string PartnerName { get; set; }

    public GetListCategoryCategoryPartnerListItemDto()
    {
        PartnerName = string.Empty;
    }

    public GetListCategoryCategoryPartnerListItemDto(int id, int partnerId, double commissionRate, string partnerName)
    {
        Id = id;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
        PartnerName = partnerName;
    }
}
