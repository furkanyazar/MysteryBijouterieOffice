using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CategoryPartnerConfiguration : IEntityTypeConfiguration<CategoryPartner>
{
    public void Configure(EntityTypeBuilder<CategoryPartner> builder)
    {
        builder.ToTable("CategoryPartners").HasKey(cp => cp.Id);

        builder.Property(cp => cp.Id).HasColumnName("Id").IsRequired();
        builder.Property(cp => cp.CategoryId).HasColumnName("CategoryId").IsRequired();
        builder.Property(cp => cp.PartnerId).HasColumnName("PartnerId").IsRequired();
        builder.Property(cp => cp.CommissionRate).HasColumnName("CommissionRate").IsRequired();
        builder.Property(cp => cp.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(cp => cp.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(cp => cp.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasIndex(cp => new { cp.CategoryId, cp.PartnerId }, "UK_CategoryPartners_CategoryId_PartnerId").IsUnique();

        builder.HasQueryFilter(cp => !cp.DeletedDate.HasValue);

        builder.HasOne(cp => cp.Category);
        builder.HasOne(cp => cp.Partner);
    }
}
