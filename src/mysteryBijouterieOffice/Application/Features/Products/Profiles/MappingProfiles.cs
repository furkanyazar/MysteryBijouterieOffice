using Application.Features.Products.Commands.Create;
using Application.Features.Products.Commands.Delete;
using Application.Features.Products.Commands.Update;
using Application.Features.Products.Queries.GetById;
using Application.Features.Products.Queries.GetList;
using Application.Features.Products.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Products.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Product, GetByIdProductResponse>().ReverseMap();

        CreateMap<Product, GetListProductListItemDto>().ReverseMap();
        CreateMap<IPaginate<Product>, GetListResponse<GetListProductListItemDto>>().ReverseMap();

        CreateMap<Product, GetListByDynamicProductListItemDto>().ReverseMap();
        CreateMap<IPaginate<Product>, GetListResponse<GetListByDynamicProductListItemDto>>().ReverseMap();

        CreateMap<Product, CreateProductCommand>()
            .ReverseMap()
            .ForMember(
                dest => dest.BarcodeNumber,
                opt => opt.MapFrom(src => !string.IsNullOrEmpty(src.BarcodeNumber) ? src.BarcodeNumber : null)
            );
        CreateMap<Product, CreatedProductResponse>().ReverseMap();

        CreateMap<Product, DeletedProductResponse>().ReverseMap();

        CreateMap<Product, UpdateProductCommand>()
            .ReverseMap()
            .ForMember(
                dest => dest.BarcodeNumber,
                opt => opt.MapFrom(src => !string.IsNullOrEmpty(src.BarcodeNumber) ? src.BarcodeNumber : null)
            );
        CreateMap<Product, UpdatedProductResponse>().ReverseMap();
    }
}
