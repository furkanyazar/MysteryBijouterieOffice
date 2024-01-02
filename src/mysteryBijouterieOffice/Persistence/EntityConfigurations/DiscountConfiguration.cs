using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.ToTable("Discounts").HasKey(d => d.Id);

        builder.Property(d => d.Id).HasColumnName("Id").IsRequired();
        builder.Property(d => d.PartnerId).HasColumnName("PartnerId").IsRequired();
        builder.Property(d => d.Name).HasColumnName("Name").IsRequired();
        builder.Property(d => d.DiscountType).HasColumnName("DiscountType").IsRequired();
        builder.Property(d => d.DiscountAmount).HasColumnName("DiscountAmount").IsRequired();
        builder.Property(d => d.DiscountLowerLimit).HasColumnName("DiscountLowerLimit").IsRequired();
        builder.Property(d => d.Priority).HasColumnName("Priority").IsRequired();
        builder.Property(d => d.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(d => d.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(d => d.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasQueryFilter(d => !d.DeletedDate.HasValue);

        builder.HasOne(d => d.Partner);
    }
}
