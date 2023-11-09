using Core.Application.Responses;

namespace Application.Features.Partners.Commands.Create;

public class CreatedPartnerResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal ShippingCost { get; set; }
    public bool HasFreeShipping { get; set; }
    public decimal FreeShippingLowerLimit { get; set; }

    public CreatedPartnerResponse()
    {
        Name = string.Empty;
    }

    public CreatedPartnerResponse(int id, string name, decimal shippingCost, bool hasFreeShipping, decimal freeShippingLowerLimit)
    {
        Id = id;
        Name = name;
        ShippingCost = shippingCost;
        HasFreeShipping = hasFreeShipping;
        FreeShippingLowerLimit = freeShippingLowerLimit;
    }
}
