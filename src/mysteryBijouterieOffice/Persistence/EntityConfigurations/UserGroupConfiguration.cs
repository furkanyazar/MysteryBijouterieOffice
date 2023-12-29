using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
{
    public void Configure(EntityTypeBuilder<UserGroup> builder)
    {
        builder.ToTable("UserGroups").HasKey(ug => ug.Id);

        builder.Property(ug => ug.Id).HasColumnName("Id").IsRequired();
        builder.Property(ug => ug.Name).HasColumnName("Name").IsRequired();
        builder.Property(ug => ug.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ug => ug.UpdatedDate).HasColumnName("UpdatedDate").IsRequired(false);
        builder.Property(ug => ug.DeletedDate).HasColumnName("DeletedDate").IsRequired(false);

        builder.HasIndex(ug => ug.Name, "UK_UserGroups_Name").IsUnique();

        builder.HasQueryFilter(ug => !ug.DeletedDate.HasValue);

        builder.HasMany(ug => ug.Users);
        builder.HasMany(ug => ug.UserGroupOperationClaims);

        builder.HasData(getSeeds());
    }

    private HashSet<UserGroup> getSeeds()
    {
        int id = 0;
        HashSet<UserGroup> seeds = new() { new UserGroup(++id, "Admin") };
        return seeds;
    }
}
