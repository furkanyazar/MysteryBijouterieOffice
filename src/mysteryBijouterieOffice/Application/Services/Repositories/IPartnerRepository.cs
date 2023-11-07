using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IPartnerRepository : IAsyncRepository<Partner, int>, IRepository<Partner, int> { }
