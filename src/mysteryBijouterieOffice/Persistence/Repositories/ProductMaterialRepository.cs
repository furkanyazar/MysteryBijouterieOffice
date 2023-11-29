using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ProductMaterialRepository : EfRepositoryBase<ProductMaterial, int, BaseDbContext>, IProductMaterialRepository
{
    public ProductMaterialRepository(BaseDbContext context)
        : base(context) { }
}
