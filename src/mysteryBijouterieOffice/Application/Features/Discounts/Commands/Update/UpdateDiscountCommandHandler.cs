using Application.Features.Discounts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Discounts.Commands.Update;

public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommand, UpdatedDiscountResponse>
{
    private readonly IDiscountRepository _discountRepository;
    private readonly IMapper _mapper;
    private readonly DiscountBusinessRules _discountBusinessRules;

    public UpdateDiscountCommandHandler(IDiscountRepository discountRepository, IMapper mapper, DiscountBusinessRules discountBusinessRules)
    {
        _discountRepository = discountRepository;
        _mapper = mapper;
        _discountBusinessRules = discountBusinessRules;
    }

    public async Task<UpdatedDiscountResponse> Handle(UpdateDiscountCommand request, CancellationToken cancellationToken)
    {
        Discount? discount = await _discountRepository.GetAsync(predicate: d => d.Id == request.Id, cancellationToken: cancellationToken);

        await _discountBusinessRules.DiscountShouldExistWhenSelected(discount);

        _mapper.Map(request, discount);

        Discount updatedDiscount = await _discountRepository.UpdateAsync(discount!);
        UpdatedDiscountResponse response = _mapper.Map<UpdatedDiscountResponse>(updatedDiscount);
        return response;
    }
}
