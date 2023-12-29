using Application.Features.Categories.Commands.Create;
using Application.Features.Categories.Commands.Delete;
using Application.Features.Categories.Commands.Update;
using Application.Features.Categories.Queries.GetById;
using Application.Features.Categories.Queries.GetList;
using Application.Features.Categories.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Categories.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Category, GetByIdCategoryResponse>().ReverseMap();

        CreateMap<Category, GetListCategoryListItemDto>().ReverseMap();
        CreateMap<IPaginate<Category>, GetListResponse<GetListCategoryListItemDto>>().ReverseMap();

        CreateMap<Category, GetListByDynamicCategoryListItemDto>().ReverseMap();
        CreateMap<IPaginate<Category>, GetListResponse<GetListByDynamicCategoryListItemDto>>().ReverseMap();

        CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        CreateMap<Category, CreatedCategoryResponse>().ReverseMap();

        CreateMap<Category, DeletedCategoryResponse>().ReverseMap();

        CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
        CreateMap<Category, UpdatedCategoryResponse>().ReverseMap();

        CreateMap<CategoryPartner, CreatedCategoryResponseCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<CreatedCategoryResponseCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, DeletedCategoryResponseCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<DeletedCategoryResponseCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, UpdatedCategoryResponseCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<UpdatedCategoryResponseCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, GetByIdCategoryResponseCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<GetByIdCategoryResponseCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, GetListCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<GetListCategoryCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, GetListByDynamicCategoryCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<GetListByDynamicCategoryCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, CreateCategoryCommandCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<CreateCategoryCommandCategoryPartnerListItemDto>>().ReverseMap();

        CreateMap<CategoryPartner, UpdateCategoryCommandCategoryPartnerListItemDto>().ReverseMap();
        CreateMap<ICollection<CategoryPartner>, List<UpdateCategoryCommandCategoryPartnerListItemDto>>().ReverseMap();
    }
}
