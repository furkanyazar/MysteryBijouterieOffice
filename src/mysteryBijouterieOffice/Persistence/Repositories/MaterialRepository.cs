using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class MaterialRepository : EfRepositoryBase<Material, int, BaseDbContext>, IMaterialRepository
{
    public MaterialRepository(BaseDbContext context)
        : base(context) { }
}
