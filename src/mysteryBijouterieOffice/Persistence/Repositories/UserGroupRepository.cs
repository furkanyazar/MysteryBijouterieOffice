using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class UserGroupRepository : EfRepositoryBase<UserGroup, int, BaseDbContext>, IUserGroupRepository
{
    public UserGroupRepository(BaseDbContext context)
        : base(context) { }
}
