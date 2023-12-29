using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Category : Entity<int>
{
    public string Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = null!;
    public virtual ICollection<CategoryPartner> CategoryPartners { get; set; } = null!;

    public Category()
    {
        Name = string.Empty;
    }

    public Category(string name)
    {
        Name = name;
    }

    public Category(int id, string name)
        : base(id)
    {
        Name = name;
    }
}
