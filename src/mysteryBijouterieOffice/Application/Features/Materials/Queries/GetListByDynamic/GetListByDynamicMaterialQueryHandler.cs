using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Materials.Queries.GetListByDynamic;

public class GetListByDynamicMaterialQueryHandler
    : IRequestHandler<GetListByDynamicMaterialQuery, GetListResponse<GetListByDynamicMaterialListItemDto>>
{
    private readonly IMaterialRepository _materialRepository;
    private readonly IMapper _mapper;

    public GetListByDynamicMaterialQueryHandler(IMaterialRepository materialRepository, IMapper mapper)
    {
        _materialRepository = materialRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListByDynamicMaterialListItemDto>> Handle(
        GetListByDynamicMaterialQuery request,
        CancellationToken cancellationToken
    )
    {
        IPaginate<Material> materials = await _materialRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize,
            cancellationToken: cancellationToken
        );
        GetListResponse<GetListByDynamicMaterialListItemDto> response = _mapper.Map<GetListResponse<GetListByDynamicMaterialListItemDto>>(
            materials
        );
        return response;
    }
}
