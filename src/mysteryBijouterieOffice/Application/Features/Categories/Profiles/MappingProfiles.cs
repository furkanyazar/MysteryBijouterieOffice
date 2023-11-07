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
    }
}
