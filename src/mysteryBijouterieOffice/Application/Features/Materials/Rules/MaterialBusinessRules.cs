using Application.Features.Materials.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Materials.Rules;

public class MaterialBusinessRules : BaseBusinessRules
{
    private readonly IMaterialRepository _materialRepository;

    public MaterialBusinessRules(IMaterialRepository materialRepository)
    {
        _materialRepository = materialRepository;
    }

    public Task MaterialShouldExistWhenSelected(Material? material)
    {
        if (material is null)
            throw new NotFoundException(MaterialsMessages.MaterialNotExists);
        return Task.CompletedTask;
    }

    public async Task MaterialNameCanNotBeDuplicatedWhenInserted(string name)
    {
        bool doesExists = await _materialRepository.AnyAsync(predicate: p => p.Name == name, withDeleted: true, enableTracking: false);
        if (doesExists)
            throw new BusinessException(MaterialsMessages.MaterialNameAlreadyExists);
    }

    public async Task MaterialNameCanNotBeDuplicatedWhenUpdated(int id, string name)
    {
        bool doesExists = await _materialRepository.AnyAsync(
            predicate: p => p.Id != id && p.Name == name,
            withDeleted: true,
            enableTracking: false
        );
        if (doesExists)
            throw new BusinessException(MaterialsMessages.MaterialNameAlreadyExists);
    }
}
