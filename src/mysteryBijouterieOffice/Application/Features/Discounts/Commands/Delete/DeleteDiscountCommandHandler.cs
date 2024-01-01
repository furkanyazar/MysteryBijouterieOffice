using Application.Features.Discounts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Discounts.Commands.Delete;

public class DeleteDiscountCommandHandler : IRequestHandler<DeleteDiscountCommand, DeletedDiscountResponse>
{
    private readonly IDiscountRepository _discountRepository;
    private readonly IMapper _mapper;
    private readonly DiscountBusinessRules _discountBusinessRules;

    public DeleteDiscountCommandHandler(IDiscountRepository discountRepository, IMapper mapper, DiscountBusinessRules discountBusinessRules)
    {
        _discountRepository = discountRepository;
        _mapper = mapper;
        _discountBusinessRules = discountBusinessRules;
    }

    public async Task<DeletedDiscountResponse> Handle(DeleteDiscountCommand request, CancellationToken cancellationToken)
    {
        Discount? discount = await _discountRepository.GetAsync(predicate: d => d.Id == request.Id, cancellationToken: cancellationToken);

        await _discountBusinessRules.DiscountShouldExistWhenSelected(discount);

        Discount deletedDiscount = await _discountRepository.DeleteAsync(discount!);
        DeletedDiscountResponse response = _mapper.Map<DeletedDiscountResponse>(deletedDiscount);
        return response;
    }
}
