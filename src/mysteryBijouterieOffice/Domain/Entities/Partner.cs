using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Partner : Entity<int>
{
    public string Name { get; set; }

    public virtual ICollection<CategoryPartner> CategoryPartners { get; set; } = null!;

    public Partner()
    {
        Name = string.Empty;
    }

    public Partner(string name)
    {
        Name = name;
    }

    public Partner(int id, string name)
        : base(id)
    {
        Name = name;
    }
}
