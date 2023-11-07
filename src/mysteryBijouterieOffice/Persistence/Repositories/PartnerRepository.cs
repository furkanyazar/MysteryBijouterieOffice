using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class PartnerRepository : EfRepositoryBase<Partner, int, BaseDbContext>, IPartnerRepository
{
    public PartnerRepository(BaseDbContext context)
        : base(context) { }
}
