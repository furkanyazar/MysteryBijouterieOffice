using Application.Features.Materials.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Materials.Commands.Create;

public class CreateMaterialCommandHandler : IRequestHandler<CreateMaterialCommand, CreatedMaterialResponse>
{
    private readonly IMaterialRepository _materialRepository;
    private readonly IMapper _mapper;
    private readonly MaterialBusinessRules _materialBusinessRules;

    public CreateMaterialCommandHandler(IMaterialRepository materialRepository, IMapper mapper, MaterialBusinessRules materialBusinessRules)
    {
        _materialRepository = materialRepository;
        _mapper = mapper;
        _materialBusinessRules = materialBusinessRules;
    }

    public async Task<CreatedMaterialResponse> Handle(CreateMaterialCommand request, CancellationToken cancellationToken)
    {
        await _materialBusinessRules.MaterialNameCanNotBeDuplicatedWhenInserted(request.Name);

        Material mappedMaterial = _mapper.Map<Material>(request);
        Material createdMaterial = await _materialRepository.AddAsync(mappedMaterial);
        CreatedMaterialResponse response = _mapper.Map<CreatedMaterialResponse>(createdMaterial);
        return response;
    }
}
 