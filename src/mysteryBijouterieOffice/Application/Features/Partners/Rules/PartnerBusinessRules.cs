using Application.Features.Partners.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Partners.Rules;

public class PartnerBusinessRules : BaseBusinessRules
{
    private readonly IPartnerRepository _partnerRepository;

    public PartnerBusinessRules(IPartnerRepository partnerRepository)
    {
        _partnerRepository = partnerRepository;
    }

    public Task PartnerShouldExistWhenSelected(Partner? partner)
    {
        if (partner is null)
            throw new NotFoundException(PartnersMessages.PartnerNotExists);
        return Task.CompletedTask;
    }

    public async Task PartnerNameCanNotBeDuplicatedWhenInserted(string name)
    {
        bool doesExists = await _partnerRepository.AnyAsync(p => p.Name == name, withDeleted: true, enableTracking: false);
        if (doesExists)
            throw new BusinessException(PartnersMessages.PartnerNameAlreadyExists);
    }

    public async Task PartnerNameCanNotBeDuplicatedWhenUpdated(int id, string name)
    {
        bool doesExists = await _partnerRepository.AnyAsync(p => p.Id != id && p.Name == name, withDeleted: true, enableTracking: false);
        if (doesExists)
            throw new BusinessException(PartnersMessages.PartnerNameAlreadyExists);
    }
}
