using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Category : Entity<int>
{
    public string Name { get; set; }
    public decimal CommissionRate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = null!;

    public Category()
    {
        Name = string.Empty;
    }

    public Category(string name, decimal commissionRate)
    {
        Name = name;
        CommissionRate = commissionRate;
    }

    public Category(int id, string name, decimal commissionRate)
        : base(id)
    {
        Name = name;
        CommissionRate = commissionRate;
    }
}
