using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.CategoryId).HasColumnName("CategoryId").IsRequired(false);
        builder.Property(p => p.Name).HasColumnName("Name").IsRequired();
        builder.Property(p => p.BarcodeNumber).HasColumnName("BarcodeNumber").IsRequired();
        builder.Property(p => p.PurchasePrice).HasColumnName("PurchasePrice").IsRequired();
        builder.Property(p => p.SalePrice).HasColumnName("SalePrice").IsRequired();
        builder.Property(p => p.ModelNumber).HasColumnName("ModelNumber").IsRequired();
        builder.Property(p => p.ImageUrl).HasColumnName("ImageUrl").IsRequired(false);
        builder.Property(p => p.Description).HasColumnName("Description").IsRequired(false);
        builder.Property(p => p.UnitsInStock).HasColumnName("UnitsInStock").IsRequired();
        builder.Property(p => p.StockCode).HasColumnName("StockCode").IsRequired(false);
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasIndex(p => p.BarcodeNumber, "UK_Products_BarcodeNumber").IsUnique();

        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);

        builder.HasOne(p => p.Category);
        builder.HasMany(p => p.ProductMaterials);
    }
}
