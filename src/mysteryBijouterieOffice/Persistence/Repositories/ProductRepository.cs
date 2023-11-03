using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ProductRepository : EfRepositoryBase<Product, int, BaseDbContext>, IProductRepository
{
    public ProductRepository(BaseDbContext context)
        : base(context) { }
}
