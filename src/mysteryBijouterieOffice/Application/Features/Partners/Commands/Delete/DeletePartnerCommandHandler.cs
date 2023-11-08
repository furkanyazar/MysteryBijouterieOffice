using Application.Features.Partners.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Partners.Commands.Delete;

public class DeletePartnerCommandHandler : IRequestHandler<DeletePartnerCommand, DeletedPartnerResponse>
{
    private readonly IPartnerRepository _partnerRepository;
    private readonly IMapper _mapper;
    private readonly PartnerBusinessRules _partnerBusinessRules;

    public DeletePartnerCommandHandler(IPartnerRepository partnerRepository, IMapper mapper, PartnerBusinessRules partnerBusinessRules)
    {
        _partnerRepository = partnerRepository;
        _mapper = mapper;
        _partnerBusinessRules = partnerBusinessRules;
    }

    public async Task<DeletedPartnerResponse> Handle(DeletePartnerCommand request, CancellationToken cancellationToken)
    {
        Partner? partner = await _partnerRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);

        await _partnerBusinessRules.PartnerShouldExistWhenSelected(partner);

        Partner deletedPartner = await _partnerRepository.DeleteAsync(partner!);
        DeletedPartnerResponse response = _mapper.Map<DeletedPartnerResponse>(deletedPartner);
        return response;
    }
}
