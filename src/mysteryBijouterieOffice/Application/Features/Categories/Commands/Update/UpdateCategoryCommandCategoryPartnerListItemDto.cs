using Core.Application.Dtos;

namespace Application.Features.Categories.Commands.Update;

public class UpdateCategoryCommandCategoryPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public double CommissionRate { get; set; }

    public UpdateCategoryCommandCategoryPartnerListItemDto() { }

    public UpdateCategoryCommandCategoryPartnerListItemDto(int id, int partnerId, double commissionRate)
    {
        Id = id;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
    }
}
