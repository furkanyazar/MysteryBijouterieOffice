using Application.Features.Products.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQuery, GetByIdProductResponse>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    private readonly ProductBusinessRules _productBusinessRules;

    public GetByIdProductQueryHandler(IProductRepository productRepository, IMapper mapper, ProductBusinessRules productBusinessRules)
    {
        _productRepository = productRepository;
        _mapper = mapper;
        _productBusinessRules = productBusinessRules;
    }

    public async Task<GetByIdProductResponse> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
    {
        Product? product = await _productRepository.GetAsync(p => p.Id == request.Id, cancellationToken: cancellationToken);

        await _productBusinessRules.ProductShouldExistWhenSelected(product);

        GetByIdProductResponse response = _mapper.Map<GetByIdProductResponse>(product);
        return response;
    }
}
