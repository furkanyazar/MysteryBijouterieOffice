using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Discounts.Queries.GetListByDynamic;

public class GetListByDynamicDiscountQueryHandler
    : IRequestHandler<GetListByDynamicDiscountQuery, GetListResponse<GetListByDynamicDiscountListItemDto>>
{
    private readonly IDiscountRepository _discountRepository;
    private readonly IMapper _mapper;

    public GetListByDynamicDiscountQueryHandler(IDiscountRepository discountRepository, IMapper mapper)
    {
        _discountRepository = discountRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListByDynamicDiscountListItemDto>> Handle(
        GetListByDynamicDiscountQuery request,
        CancellationToken cancellationToken
    )
    {
        IPaginate<Discount> discounts = await _discountRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize,
            cancellationToken: cancellationToken
        );
        GetListResponse<GetListByDynamicDiscountListItemDto> response = _mapper.Map<GetListResponse<GetListByDynamicDiscountListItemDto>>(
            discounts
        );
        return response;
    }
}
