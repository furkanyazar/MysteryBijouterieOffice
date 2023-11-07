using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories").HasKey(c => c.Id);

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasIndex(c => c.Name, "UK_Categories_Name").IsUnique();

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

        builder.HasMany(c => c.Products);
        builder.HasMany(c => c.CategoryPartners);
    }
}
