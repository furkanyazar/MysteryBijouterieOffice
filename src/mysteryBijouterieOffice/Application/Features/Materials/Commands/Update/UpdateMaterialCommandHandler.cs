using Application.Features.Materials.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Materials.Commands.Update;

public class UpdateMaterialCommandHandler : IRequestHandler<UpdateMaterialCommand, UpdatedMaterialResponse>
{
    private readonly IMaterialRepository _materialRepository;
    private readonly IMapper _mapper;
    private readonly MaterialBusinessRules _materialBusinessRules;

    public UpdateMaterialCommandHandler(IMaterialRepository materialRepository, IMapper mapper, MaterialBusinessRules materialBusinessRules)
    {
        _materialRepository = materialRepository;
        _mapper = mapper;
        _materialBusinessRules = materialBusinessRules;
    }

    public async Task<UpdatedMaterialResponse> Handle(UpdateMaterialCommand request, CancellationToken cancellationToken)
    {
        Material? material = await _materialRepository.GetAsync(predicate: m => m.Id == request.Id, cancellationToken: cancellationToken);

        await _materialBusinessRules.MaterialShouldExistWhenSelected(material);
        await _materialBusinessRules.MaterialNameCanNotBeDuplicatedWhenUpdated(request.Id, request.Name);

        _mapper.Map(request, material);

        Material updatedMaterial = await _materialRepository.UpdateAsync(material!);
        UpdatedMaterialResponse response = _mapper.Map<UpdatedMaterialResponse>(updatedMaterial);
        return response;
    }
}
