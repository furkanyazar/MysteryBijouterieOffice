using Core.Application.Dtos;

namespace Application.Features.Products.Commands.Delete;

public class DeletedProductResponseCategoryCategoryPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int PartnerId { get; set; }
    public double CommissionRate { get; set; }

    public DeletedProductResponseCategoryCategoryPartnerListItemDto() { }

    public DeletedProductResponseCategoryCategoryPartnerListItemDto(int id, int categoryId, int partnerId, double commissionRate)
    {
        Id = id;
        CategoryId = categoryId;
        PartnerId = partnerId;
        CommissionRate = commissionRate;
    }
}
