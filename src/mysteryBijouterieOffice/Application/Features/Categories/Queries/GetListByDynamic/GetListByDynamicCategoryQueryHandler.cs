using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Queries.GetListByDynamic;

public class GetListByDynamicCategoryQueryHandler
    : IRequestHandler<GetListByDynamicCategoryQuery, GetListResponse<GetListByDynamicCategoryListItemDto>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public GetListByDynamicCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListByDynamicCategoryListItemDto>> Handle(
        GetListByDynamicCategoryQuery request,
        CancellationToken cancellationToken
    )
    {
        IPaginate<Category> categories = await _categoryRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize,
            cancellationToken: cancellationToken
        );
        GetListResponse<GetListByDynamicCategoryListItemDto> response = _mapper.Map<GetListResponse<GetListByDynamicCategoryListItemDto>>(
            categories
        );
        return response;
    }
}
