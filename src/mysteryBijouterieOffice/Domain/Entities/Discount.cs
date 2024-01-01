using Core.Persistence.Repositories;
using Domain.Enums;

namespace Domain.Entities;

public class Discount : Entity<int>
{
    public int PartnerId { get; set; }
    public string Name { get; set; }
    public DiscountType DiscountType { get; set; }
    public decimal DiscountAmount { get; set; }

    public virtual Partner Partner { get; set; } = null!;

    public Discount()
    {
        Name = string.Empty;
    }

    public Discount(int partnerId, string name, DiscountType discountType, decimal discountAmount)
    {
        Name = name;
        PartnerId = partnerId;
        DiscountType = discountType;
        DiscountAmount = discountAmount;
    }

    public Discount(int id, int partnerId, string name, DiscountType discountType, decimal discountAmount)
        : base(id)
    {
        Name = name;
        PartnerId = partnerId;
        DiscountType = discountType;
        DiscountAmount = discountAmount;
    }
}
