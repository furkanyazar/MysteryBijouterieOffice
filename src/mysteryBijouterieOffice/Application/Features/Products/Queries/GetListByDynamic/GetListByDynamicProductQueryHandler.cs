using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Products.Queries.GetListByDynamic;

public class GetListByDynamicProductQueryHandler
    : IRequestHandler<GetListByDynamicProductQuery, GetListResponse<GetListByDynamicProductListItemDto>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetListByDynamicProductQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListByDynamicProductListItemDto>> Handle(
        GetListByDynamicProductQuery request,
        CancellationToken cancellationToken
    )
    {
        IPaginate<Product> products = await _productRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            include: p =>
                p.Include(p => p.Category)
                    .ThenInclude(c => c!.CategoryPartners)
                    .Include(p => p.ProductMaterials)
                    .ThenInclude(pm => pm.Material),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize,
            cancellationToken: cancellationToken
        );
        GetListResponse<GetListByDynamicProductListItemDto> response = _mapper.Map<GetListResponse<GetListByDynamicProductListItemDto>>(
            products
        );
        return response;
    }
}
