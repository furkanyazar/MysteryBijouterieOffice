using Core.Application.Dtos;

namespace Application.Features.Categories.Commands.Create;

public class CreatedCategoryResponseCategoryPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public decimal CommissionRate { get; set; }
    public string PartnerName { get; set; }

    public CreatedCategoryResponseCategoryPartnerListItemDto()
    {
        PartnerName = string.Empty;
    }

    public CreatedCategoryResponseCategoryPartnerListItemDto(int id, int partnerId, decimal commissionRate, string partnerName)
    {
        Id = id;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
        PartnerName = partnerName;
    }
}
