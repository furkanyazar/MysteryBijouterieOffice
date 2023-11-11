using Core.Application.Responses;

namespace Application.Features.Partners.Queries.GetById;

public class GetByIdPartnerResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal ShippingCost { get; set; }
    public bool HasFreeShipping { get; set; }
    public decimal FreeShippingLowerLimit { get; set; }
    public decimal ServiceFee { get; set; }

    public GetByIdPartnerResponse()
    {
        Name = string.Empty;
    }

    public GetByIdPartnerResponse(
        int id,
        string name,
        decimal shippingCost,
        bool hasFreeShipping,
        decimal freeShippingLowerLimit,
        decimal serviceFee
    )
    {
        Id = id;
        Name = name;
        ShippingCost = shippingCost;
        HasFreeShipping = hasFreeShipping;
        FreeShippingLowerLimit = freeShippingLowerLimit;
        ServiceFee = serviceFee;
    }
}
