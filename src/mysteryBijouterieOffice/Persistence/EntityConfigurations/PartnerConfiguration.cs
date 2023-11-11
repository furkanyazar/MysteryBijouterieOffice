using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
{
    public void Configure(EntityTypeBuilder<Partner> builder)
    {
        builder.ToTable("Partners").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Name).HasColumnName("Name").IsRequired();
        builder.Property(p => p.ShippingCost).HasColumnName("ShippingCost").IsRequired();
        builder.Property(p => p.HasFreeShipping).HasColumnName("HasFreeShipping").IsRequired();
        builder.Property(p => p.FreeShippingLowerLimit).HasColumnName("FreeShippingLowerLimit").IsRequired();
        builder.Property(p => p.ServiceFee).HasColumnName("ServiceFee").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasIndex(p => p.Name, "UK_Partners_Name").IsUnique();

        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);

        builder.HasMany(p => p.CategoryPartners);
    }
}
