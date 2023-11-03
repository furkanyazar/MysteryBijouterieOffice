﻿using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class EmailAuthenticatorConfiguration : IEntityTypeConfiguration<EmailAuthenticator>
{
    public void Configure(EntityTypeBuilder<EmailAuthenticator> builder)
    {
        builder.ToTable("EmailAuthenticators").HasKey(ea => ea.Id);

        builder.Property(ea => ea.Id).HasColumnName("Id").IsRequired();
        builder.Property(ea => ea.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(ea => ea.ActivationKey).HasColumnName("ActivationKey").IsRequired(false);
        builder.Property(ea => ea.IsVerified).HasColumnName("IsVerified").IsRequired();
        builder.Property(ea => ea.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ea => ea.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(ea => ea.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasIndex(ea => ea.UserId, "UK_EmailAuthenticators_UserId").IsUnique();

        builder.HasQueryFilter(ea => !ea.DeletedDate.HasValue);

        builder.HasOne(ea => ea.User);
    }
}
