using Application.Features.Partners.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Partners.Queries.GetById;

public class GetByIdPartnerQueryHandler : IRequestHandler<GetByIdPartnerQuery, GetByIdPartnerResponse>
{
    private readonly IPartnerRepository _partnerRepository;
    private readonly IMapper _mapper;
    private readonly PartnerBusinessRules _partnerBusinessRules;

    public GetByIdPartnerQueryHandler(IPartnerRepository partnerRepository, IMapper mapper, PartnerBusinessRules partnerBusinessRules)
    {
        _partnerRepository = partnerRepository;
        _mapper = mapper;
        _partnerBusinessRules = partnerBusinessRules;
    }

    public async Task<GetByIdPartnerResponse> Handle(GetByIdPartnerQuery request, CancellationToken cancellationToken)
    {
        Partner? partner = await _partnerRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);

        await _partnerBusinessRules.PartnerShouldExistWhenSelected(partner);

        GetByIdPartnerResponse response = _mapper.Map<GetByIdPartnerResponse>(partner);
        return response;
    }
}
