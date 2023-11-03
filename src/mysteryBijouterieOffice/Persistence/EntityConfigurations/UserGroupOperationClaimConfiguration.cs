using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class UserGroupOperationClaimConfiguration : IEntityTypeConfiguration<UserGroupOperationClaim>
{
    public void Configure(EntityTypeBuilder<UserGroupOperationClaim> builder)
    {
        builder.ToTable("UserGroupOperationClaims").HasKey(uoc => uoc.Id);

        builder.Property(uoc => uoc.Id).HasColumnName("Id").IsRequired();
        builder.Property(uoc => uoc.UserGroupId).HasColumnName("UserGroupId").IsRequired();
        builder.Property(uoc => uoc.OperationClaimId).HasColumnName("OperationClaimId").IsRequired();
        builder.Property(uoc => uoc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(uoc => uoc.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(uoc => uoc.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder
            .HasIndex(uoc => new { uoc.UserGroupId, uoc.OperationClaimId }, "UK_UserGroupOperationClaims_UserGroupId_OperationClaimId")
            .IsUnique();

        builder.HasQueryFilter(uoc => !uoc.DeletedDate.HasValue);

        builder.HasOne(uoc => uoc.UserGroup);
        builder.HasOne(uoc => uoc.OperationClaim);

        builder.HasData(getSeeds());
    }

    private HashSet<UserGroupOperationClaim> getSeeds()
    {
        int id = 0;
        HashSet<UserGroupOperationClaim> seeds = new() { new UserGroupOperationClaim(++id, 1, 1) };
        return seeds;
    }
}
