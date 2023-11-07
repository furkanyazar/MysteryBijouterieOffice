using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Partners.Queries.GetList;

public class GetListPartnerQueryHandler : IRequestHandler<GetListPartnerQuery, GetListResponse<GetListPartnerListItemDto>>
{
    private readonly IPartnerRepository _partnerRepository;
    private readonly IMapper _mapper;

    public GetListPartnerQueryHandler(IPartnerRepository partnerRepository, IMapper mapper)
    {
        _partnerRepository = partnerRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListPartnerListItemDto>> Handle(GetListPartnerQuery request, CancellationToken cancellationToken)
    {
        IPaginate<Partner> partners = await _partnerRepository.GetListAsync(
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize,
            cancellationToken: cancellationToken
        );
        GetListResponse<GetListPartnerListItemDto> response = _mapper.Map<GetListResponse<GetListPartnerListItemDto>>(partners);
        return response;
    }
}
