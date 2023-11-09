using Core.Application.Responses;

namespace Application.Features.Partners.Commands.Update;

public class UpdatedPartnerResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal ShippingCost { get; set; }
    public bool HasFreeShipping { get; set; }
    public decimal FreeShippingLowerLimit { get; set; }

    public UpdatedPartnerResponse()
    {
        Name = string.Empty;
    }

    public UpdatedPartnerResponse(int id, string name, decimal shippingCost, bool hasFreeShipping, decimal freeShippingLowerLimit)
    {
        Id = id;
        Name = name;
        ShippingCost = shippingCost;
        HasFreeShipping = hasFreeShipping;
        FreeShippingLowerLimit = freeShippingLowerLimit;
    }
}
