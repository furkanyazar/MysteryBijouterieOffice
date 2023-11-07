using Application.Features.Partners.Commands.Create;
using Application.Features.Partners.Commands.Delete;
using Application.Features.Partners.Commands.Update;
using Application.Features.Partners.Queries.GetById;
using Application.Features.Partners.Queries.GetList;
using Application.Features.Partners.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Partners.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Partner, GetByIdPartnerResponse>().ReverseMap();

        CreateMap<Partner, GetListPartnerListItemDto>().ReverseMap();
        CreateMap<IPaginate<Partner>, GetListResponse<GetListPartnerListItemDto>>().ReverseMap();

        CreateMap<Partner, GetListByDynamicPartnerListItemDto>().ReverseMap();
        CreateMap<IPaginate<Partner>, GetListResponse<GetListByDynamicPartnerListItemDto>>().ReverseMap();

        CreateMap<Partner, CreatePartnerCommand>().ReverseMap();
        CreateMap<Partner, CreatedPartnerResponse>().ReverseMap();

        CreateMap<Partner, DeletedPartnerResponse>().ReverseMap();

        CreateMap<Partner, UpdatePartnerCommand>().ReverseMap();
        CreateMap<Partner, UpdatedPartnerResponse>().ReverseMap();
    }
}
