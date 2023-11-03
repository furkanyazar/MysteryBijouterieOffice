using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories;

public interface IUserGroupOperationClaimRepository
    : IAsyncRepository<UserGroupOperationClaim, int>,
        IRepository<UserGroupOperationClaim, int> { }
