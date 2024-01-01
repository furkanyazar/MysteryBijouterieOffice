using Core.Application.Responses;

namespace Application.Features.Discounts.Commands.Update;

public class UpdatedDiscountResponse : IResponse
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public string Name { get; set; }
    public int DiscountType { get; set; }
    public decimal DiscountAmount { get; set; }

    public UpdatedDiscountResponse()
    {
        Name = string.Empty;
    }

    public UpdatedDiscountResponse(int id, int partnerId, string name, int discountType, decimal discountAmount)
    {
        Id = id;
        PartnerId = partnerId;
        Name = name;
        DiscountType = discountType;
        DiscountAmount = discountAmount;
    }
}
