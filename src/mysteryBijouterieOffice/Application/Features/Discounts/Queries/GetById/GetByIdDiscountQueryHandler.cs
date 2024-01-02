using Application.Features.Discounts.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Discounts.Queries.GetById;

public class GetByIdDiscountQueryHandler : IRequestHandler<GetByIdDiscountQuery, GetByIdDiscountResponse>
{
    private readonly IDiscountRepository _discountRepository;
    private readonly IMapper _mapper;
    private readonly DiscountBusinessRules _discountBusinessRules;

    public GetByIdDiscountQueryHandler(IDiscountRepository discountRepository, IMapper mapper, DiscountBusinessRules discountBusinessRules)
    {
        _discountRepository = discountRepository;
        _mapper = mapper;
        _discountBusinessRules = discountBusinessRules;
    }

    public async Task<GetByIdDiscountResponse> Handle(GetByIdDiscountQuery request, CancellationToken cancellationToken)
    {
        Discount? discount = await _discountRepository.GetAsync(
            predicate: d => d.Id == request.Id,
            include: d => d.Include(d => d.Partner),
            cancellationToken: cancellationToken
        );

        await _discountBusinessRules.DiscountShouldExistWhenSelected(discount);

        GetByIdDiscountResponse response = _mapper.Map<GetByIdDiscountResponse>(discount);
        return response;
    }
}
