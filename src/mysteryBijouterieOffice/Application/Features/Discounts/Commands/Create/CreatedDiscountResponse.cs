using Core.Application.Responses;

namespace Application.Features.Discounts.Commands.Create;

public class CreatedDiscountResponse : IResponse
{
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public string Name { get; set; }
    public int DiscountType { get; set; }
    public decimal DiscountAmount { get; set; }

    public CreatedDiscountResponse()
    {
        Name = string.Empty;
    }

    public CreatedDiscountResponse(int id, int partnerId, string name, int discountType, decimal discountAmount)
    {
        Id = id;
        PartnerId = partnerId;
        Name = name;
        DiscountType = discountType;
        DiscountAmount = discountAmount;
    }
}
