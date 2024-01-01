using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Discounts.Commands.Create;

public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommand, CreatedDiscountResponse>
{
    private readonly IDiscountRepository _discountRepository;
    private readonly IMapper _mapper;

    public CreateDiscountCommandHandler(IDiscountRepository discountRepository, IMapper mapper)
    {
        _discountRepository = discountRepository;
        _mapper = mapper;
    }

    public async Task<CreatedDiscountResponse> Handle(CreateDiscountCommand request, CancellationToken cancellationToken)
    {
        Discount mappedDiscount = _mapper.Map<Discount>(request);
        Discount createdDiscount = await _discountRepository.AddAsync(mappedDiscount);
        CreatedDiscountResponse response = _mapper.Map<CreatedDiscountResponse>(createdDiscount);
        return response;
    }
}
