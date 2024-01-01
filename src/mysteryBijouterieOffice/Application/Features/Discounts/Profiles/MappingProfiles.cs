using Application.Features.Discounts.Commands.Create;
using Application.Features.Discounts.Commands.Delete;
using Application.Features.Discounts.Commands.Update;
using Application.Features.Discounts.Queries.GetById;
using Application.Features.Discounts.Queries.GetList;
using Application.Features.Discounts.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Discounts.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Discount, GetByIdDiscountResponse>().ReverseMap();

        CreateMap<Discount, GetListDiscountListItemDto>().ReverseMap();
        CreateMap<IPaginate<Discount>, GetListResponse<GetListDiscountListItemDto>>().ReverseMap();

        CreateMap<Discount, GetListByDynamicDiscountListItemDto>().ReverseMap();
        CreateMap<IPaginate<Discount>, GetListResponse<GetListByDynamicDiscountListItemDto>>().ReverseMap();

        CreateMap<Discount, CreateDiscountCommand>().ReverseMap();
        CreateMap<Discount, CreatedDiscountResponse>().ReverseMap();

        CreateMap<Discount, DeletedDiscountResponse>().ReverseMap();

        CreateMap<Discount, UpdateDiscountCommand>().ReverseMap();
        CreateMap<Discount, UpdatedDiscountResponse>().ReverseMap();
    }
}
