using Core.Security.Constants;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperationClaims").HasKey(oc => oc.Id);

        builder.Property(oc => oc.Id).HasColumnName("Id").IsRequired();
        builder.Property(oc => oc.ParentOperationClaimId).HasColumnName("ParentOperationClaimId").IsRequired(false);
        builder.Property(oc => oc.Name).HasColumnName("Name").IsRequired();
        builder.Property(oc => oc.Value).HasColumnName("Value").IsRequired();
        builder.Property(oc => oc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(oc => oc.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(oc => oc.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasIndex(oc => oc.Name, "UK_OperationClaims_Name").IsUnique();
        builder.HasIndex(oc => oc.Value, "UK_OperationClaims_Value").IsUnique();

        builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);

        builder.HasOne(oc => oc.ParentOperationClaim);
        builder.HasMany(oc => oc.UserGroupOperationClaims);

        builder.HasData(getSeeds());
    }

    private HashSet<OperationClaim> getSeeds()
    {
        int id = 0;
        HashSet<OperationClaim> seeds = new() { new OperationClaim(++id, null, "Admin", GeneralOperationClaims.Admin) };
        return seeds;
    }
}
