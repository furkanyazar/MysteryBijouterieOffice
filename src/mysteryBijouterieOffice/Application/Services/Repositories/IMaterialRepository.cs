using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IMaterialRepository : IAsyncRepository<Material, int>, IRepository<Material, int> { }
