using Application.Features.Partners.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Partners.Commands.Update;

public class UpdatePartnerCommandHandler : IRequestHandler<UpdatePartnerCommand, UpdatedPartnerResponse>
{
    private readonly IPartnerRepository _partnerRepository;
    private readonly IMapper _mapper;
    private readonly PartnerBusinessRules _partnerBusinessRules;

    public UpdatePartnerCommandHandler(IPartnerRepository partnerRepository, IMapper mapper, PartnerBusinessRules partnerBusinessRules)
    {
        _partnerRepository = partnerRepository;
        _mapper = mapper;
        _partnerBusinessRules = partnerBusinessRules;
    }

    public async Task<UpdatedPartnerResponse> Handle(UpdatePartnerCommand request, CancellationToken cancellationToken)
    {
        Partner? partner = await _partnerRepository.GetAsync(p => p.Id == request.Id, cancellationToken: cancellationToken);

        await _partnerBusinessRules.PartnerShouldExistWhenSelected(partner);
        await _partnerBusinessRules.PartnerNameCanNotBeDuplicatedWhenUpdated(request.Id, request.Name);

        _mapper.Map(request, partner);

        Partner updatedPartner = await _partnerRepository.UpdateAsync(partner!);
        UpdatedPartnerResponse response = _mapper.Map<UpdatedPartnerResponse>(updatedPartner);
        return response;
    }
}
