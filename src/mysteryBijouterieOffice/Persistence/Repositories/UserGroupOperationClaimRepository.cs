using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class UserGroupOperationClaimRepository
    : EfRepositoryBase<UserGroupOperationClaim, int, BaseDbContext>,
        IUserGroupOperationClaimRepository
{
    public UserGroupOperationClaimRepository(BaseDbContext context)
        : base(context) { }
}
