using Application.Features.Materials.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Materials.Commands.Delete;

public class DeleteMaterialCommandHandler : IRequestHandler<DeleteMaterialCommand, DeletedMaterialResponse>
{
    private readonly IMaterialRepository _materialRepository;
    private readonly IMapper _mapper;
    private readonly MaterialBusinessRules _materialBusinessRules;

    public DeleteMaterialCommandHandler(IMaterialRepository materialRepository, IMapper mapper, MaterialBusinessRules materialBusinessRules)
    {
        _materialRepository = materialRepository;
        _mapper = mapper;
        _materialBusinessRules = materialBusinessRules;
    }

    public async Task<DeletedMaterialResponse> Handle(DeleteMaterialCommand request, CancellationToken cancellationToken)
    {
        Material? material = await _materialRepository.GetAsync(predicate: m => m.Id == request.Id, cancellationToken: cancellationToken);

        await _materialBusinessRules.MaterialShouldExistWhenSelected(material);

        Material deletedMaterial = await _materialRepository.DeleteAsync(material!);
        DeletedMaterialResponse response = _mapper.Map<DeletedMaterialResponse>(deletedMaterial);
        return response;
    }
}
