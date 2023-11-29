using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IProductMaterialRepository : IAsyncRepository<ProductMaterial, int>, IRepository<ProductMaterial, int> { }
