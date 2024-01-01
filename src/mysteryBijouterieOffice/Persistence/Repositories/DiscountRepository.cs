using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class DiscountRepository : EfRepositoryBase<Discount, int, BaseDbContext>, IDiscountRepository
{
    public DiscountRepository(BaseDbContext context)
        : base(context) { }
}
