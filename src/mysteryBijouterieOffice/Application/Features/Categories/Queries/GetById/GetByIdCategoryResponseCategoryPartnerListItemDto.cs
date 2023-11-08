using Core.Application.Dtos;

namespace Application.Features.Categories.Queries.GetById;

public class GetByIdCategoryResponseCategoryPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public double CommissionRate { get; set; }
    public string PartnerName { get; set; }

    public GetByIdCategoryResponseCategoryPartnerListItemDto()
    {
        PartnerName = string.Empty;
    }

    public GetByIdCategoryResponseCategoryPartnerListItemDto(int id, int partnerId, double commissionRate, string partnerName)
    {
        Id = id;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
        PartnerName = partnerName;
    }
}
