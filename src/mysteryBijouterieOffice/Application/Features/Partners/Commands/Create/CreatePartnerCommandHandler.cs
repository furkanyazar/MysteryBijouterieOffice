using Application.Features.Partners.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Partners.Commands.Create;

public class CreatePartnerCommandHandler : IRequestHandler<CreatePartnerCommand, CreatedPartnerResponse>
{
    private readonly IPartnerRepository _partnerRepository;
    private readonly IMapper _mapper;
    private readonly PartnerBusinessRules _partnerBusinessRules;

    public CreatePartnerCommandHandler(IPartnerRepository partnerRepository, IMapper mapper, PartnerBusinessRules partnerBusinessRules)
    {
        _partnerRepository = partnerRepository;
        _mapper = mapper;
        _partnerBusinessRules = partnerBusinessRules;
    }

    public async Task<CreatedPartnerResponse> Handle(CreatePartnerCommand request, CancellationToken cancellationToken)
    {
        await _partnerBusinessRules.PartnerNameCanNotBeDuplicatedWhenInserted(request.Name);

        Partner mappedPartner = _mapper.Map<Partner>(request);
        Partner createdPartner = await _partnerRepository.AddAsync(mappedPartner);
        CreatedPartnerResponse response = _mapper.Map<CreatedPartnerResponse>(createdPartner);
        return response;
    }
}
