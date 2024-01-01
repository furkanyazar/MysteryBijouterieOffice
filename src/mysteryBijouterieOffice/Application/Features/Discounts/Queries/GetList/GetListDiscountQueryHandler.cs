using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Discounts.Queries.GetList;

public class GetListDiscountQueryHandler : IRequestHandler<GetListDiscountQuery, GetListResponse<GetListDiscountListItemDto>>
{
    private readonly IDiscountRepository _discountRepository;
    private readonly IMapper _mapper;

    public GetListDiscountQueryHandler(IDiscountRepository discountRepository, IMapper mapper)
    {
        _discountRepository = discountRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListDiscountListItemDto>> Handle(GetListDiscountQuery request, CancellationToken cancellationToken)
    {
        IPaginate<Discount> discounts = await _discountRepository.GetListAsync(
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize,
            cancellationToken: cancellationToken
        );
        GetListResponse<GetListDiscountListItemDto> response = _mapper.Map<GetListResponse<GetListDiscountListItemDto>>(discounts);
        return response;
    }
}
