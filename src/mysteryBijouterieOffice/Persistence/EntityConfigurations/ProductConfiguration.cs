﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products").HasKey(u => u.Id);

        builder.Property(u => u.Id).HasColumnName("Id").IsRequired();
        builder.Property(u => u.Name).HasColumnName("Name").IsRequired();
        builder.Property(u => u.BarcodeNumber).HasColumnName("BarcodeNumber").IsRequired();
        builder.Property(u => u.UnitPrice).HasColumnName("UnitPrice").IsRequired();
        builder.Property(u => u.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(u => u.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(u => u.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasIndex(u => u.BarcodeNumber, "UK_Products_BarcodeNumber").IsUnique();

        builder.HasQueryFilter(u => !u.DeletedDate.HasValue);
    }
}
