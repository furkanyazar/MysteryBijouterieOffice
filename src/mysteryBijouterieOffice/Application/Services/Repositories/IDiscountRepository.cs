using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IDiscountRepository : IAsyncRepository<Discount, int>, IRepository<Discount, int> { }
