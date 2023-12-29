using Core.Application.Dtos;

namespace Application.Features.Categories.Commands.Delete;

public class DeletedCategoryResponseCategoryPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public double CommissionRate { get; set; }
    public string PartnerName { get; set; }

    public DeletedCategoryResponseCategoryPartnerListItemDto()
    {
        PartnerName = string.Empty;
    }

    public DeletedCategoryResponseCategoryPartnerListItemDto(int id, int partnerId, double commissionRate, string partnerName)
    {
        Id = id;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
        PartnerName = partnerName;
    }
}
