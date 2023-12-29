using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Partners.Queries.GetListByDynamic;

public class GetListByDynamicPartnerQueryHandler
    : IRequestHandler<GetListByDynamicPartnerQuery, GetListResponse<GetListByDynamicPartnerListItemDto>>
{
    private readonly IPartnerRepository _partnerRepository;
    private readonly IMapper _mapper;

    public GetListByDynamicPartnerQueryHandler(IPartnerRepository partnerRepository, IMapper mapper)
    {
        _partnerRepository = partnerRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListByDynamicPartnerListItemDto>> Handle(
        GetListByDynamicPartnerQuery request,
        CancellationToken cancellationToken
    )
    {
        IPaginate<Partner> partners = await _partnerRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize,
            cancellationToken: cancellationToken
        );
        GetListResponse<GetListByDynamicPartnerListItemDto> response = _mapper.Map<GetListResponse<GetListByDynamicPartnerListItemDto>>(
            partners
        );
        return response;
    }
}
