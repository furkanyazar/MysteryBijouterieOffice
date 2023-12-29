using Core.Application.Dtos;

namespace Application.Features.Categories.Commands.Update;

public class UpdatedCategoryResponseCategoryPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public decimal CommissionRate { get; set; }
    public string PartnerName { get; set; }

    public UpdatedCategoryResponseCategoryPartnerListItemDto()
    {
        PartnerName = string.Empty;
    }

    public UpdatedCategoryResponseCategoryPartnerListItemDto(int id, int partnerId, decimal commissionRate, string partnerName)
    {
        Id = id;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
        PartnerName = partnerName;
    }
}
