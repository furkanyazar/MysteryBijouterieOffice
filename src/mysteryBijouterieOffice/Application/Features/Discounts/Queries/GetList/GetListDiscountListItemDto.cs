using Core.Application.Dtos;

namespace Application.Features.Discounts.Queries.GetList;

public class GetListDiscountListItemDto : IDto
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public string Name { get; set; }
    public int DiscountType { get; set; }
    public decimal DiscountAmount { get; set; }

    public GetListDiscountListItemDto()
    {
        Name = string.Empty;
    }

    public GetListDiscountListItemDto(int id, int partnerId, string name, int discountType, decimal discountAmount)
    {
        Id = id;
        PartnerId = partnerId;
        Name = name;
        DiscountType = discountType;
        DiscountAmount = discountAmount;
    }
}
