using Application.Features.Products.Commands.Create;
using Application.Features.Products.Commands.Delete;
using Application.Features.Products.Commands.Update;
using Application.Features.Products.Commands.UpdateSalePrice;
using Application.Features.Products.Commands.UploadImage;
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
            .ForMember(dest => dest.SalePrice, opt => opt.MapFrom(src => src.PurchasePrice * 2));
        CreateMap<Product, CreatedProductResponse>().ReverseMap();

        CreateMap<Product, DeletedProductResponse>().ReverseMap();

        CreateMap<Product, UpdateProductCommand>().ReverseMap();
        CreateMap<Product, UpdatedProductResponse>().ReverseMap();

        CreateMap<CategoryPartner, CreatedProductResponseCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<CreatedProductResponseCategoryCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, DeletedProductResponseCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<DeletedProductResponseCategoryCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, UpdatedProductResponseCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<UpdatedProductResponseCategoryCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, GetByIdProductResponseCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<GetByIdProductResponseCategoryCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, GetListProductCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<GetListProductCategoryCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, GetListByDynamicProductCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<GetListByDynamicProductCategoryCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<Product, UploadedImageResponse>().ReverseMap();

        CreateMap<CategoryPartner, UploadedImageResponseCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<UploadedImageResponseCategoryCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<Product, UpdateSalePriceCommand>().ReverseMap();
        CreateMap<Product, UpdatedSalePriceResponse>().ReverseMap();

        CreateMap<CategoryPartner, UpdatedSalePriceResponseCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<UpdatedSalePriceResponseCategoryCategoryPartnerListItemDto>>().ReverseMap();
    }
}
