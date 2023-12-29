using Core.Application.Dtos;

namespace Application.Features.Categories.Commands.Create;

public class CreateCategoryCommandCategoryPartnerListItemDto : IDto
{
    public int PartnerId { get; set; }
    public double CommissionRate { get; set; }

    public CreateCategoryCommandCategoryPartnerListItemDto() { }

    public CreateCategoryCommandCategoryPartnerListItemDto(int partnerId, double commissionRate)
    {
        PartnerId = partnerId;
        CommissionRate = commissionRate;
    }
}
