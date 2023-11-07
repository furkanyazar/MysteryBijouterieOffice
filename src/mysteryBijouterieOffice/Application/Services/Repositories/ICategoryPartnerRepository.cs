using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ICategoryPartnerRepository : IAsyncRepository<CategoryPartner, int>, IRepository<CategoryPartner, int> { }
