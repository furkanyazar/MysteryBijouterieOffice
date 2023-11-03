using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories;

public interface IUserGroupRepository : IAsyncRepository<UserGroup, int>, IRepository<UserGroup, int> { }
