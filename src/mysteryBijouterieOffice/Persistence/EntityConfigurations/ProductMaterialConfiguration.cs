using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ProductMaterialConfiguration : IEntityTypeConfiguration<ProductMaterial>
{
    public void Configure(EntityTypeBuilder<ProductMaterial> builder)
    {
        builder.ToTable("ProductMaterials").HasKey(cp => cp.Id);

        builder.Property(cp => cp.Id).HasColumnName("Id").IsRequired();
        builder.Property(cp => cp.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(cp => cp.MaterialId).HasColumnName("MaterialId").IsRequired();
        builder.Property(cp => cp.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(cp => cp.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(cp => cp.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasIndex(cp => new { cp.ProductId, cp.MaterialId }, "UK_ProductMaterials_ProductId_MaterialId").IsUnique();

        builder.HasQueryFilter(cp => !cp.DeletedDate.HasValue);

        builder.HasOne(cp => cp.Product);
        builder.HasOne(cp => cp.Material);
    }
}
