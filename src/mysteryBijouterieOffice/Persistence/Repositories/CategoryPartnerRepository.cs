using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class CategoryPartnerRepository : EfRepositoryBase<CategoryPartner, int, BaseDbContext>, ICategoryPartnerRepository
{
    public CategoryPartnerRepository(BaseDbContext context)
        : base(context) { }
}
