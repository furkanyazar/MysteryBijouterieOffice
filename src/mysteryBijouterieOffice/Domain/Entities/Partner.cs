using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Partner : Entity<int>
{
    public string Name { get; set; }
    public decimal ShippingCost { get; set; }
    public bool HasFreeShipping { get; set; }
    public decimal FreeShippingLowerLimit { get; set; }

    public virtual ICollection<CategoryPartner> CategoryPartners { get; set; } = null!;

    public Partner()
    {
        Name = string.Empty;
    }

    public Partner(string name, decimal shippingCost, decimal freeShippingLowerLimit)
    {
        Name = name;
        ShippingCost = shippingCost;
        FreeShippingLowerLimit = freeShippingLowerLimit;
    }

    public Partner(int id, string name, decimal shippingCost, decimal freeShippingLowerLimit)
        : base(id)
    {
        Name = name;
        ShippingCost = shippingCost;
        FreeShippingLowerLimit = freeShippingLowerLimit;
    }
}
