﻿using Application.Features.Materials.Commands.Create;
using Application.Features.Materials.Commands.Delete;
using Application.Features.Materials.Commands.Update;
using Application.Features.Materials.Queries.GetById;
using Application.Features.Materials.Queries.GetList;
using Application.Features.Materials.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Materials.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Material, GetByIdMaterialResponse>().ReverseMap();

        CreateMap<Material, GetListMaterialListItemDto>().ReverseMap();
        CreateMap<IPaginate<Material>, GetListResponse<GetListMaterialListItemDto>>().ReverseMap();

        CreateMap<Material, GetListByDynamicMaterialListItemDto>().ReverseMap();
        CreateMap<IPaginate<Material>, GetListResponse<GetListByDynamicMaterialListItemDto>>().ReverseMap();

        CreateMap<Material, CreateMaterialCommand>().ReverseMap();
        CreateMap<Material, CreatedMaterialResponse>().ReverseMap();

        CreateMap<Material, DeletedMaterialResponse>().ReverseMap();

        CreateMap<Material, UpdateMaterialCommand>().ReverseMap();
        CreateMap<Material, UpdatedMaterialResponse>().ReverseMap();
    }
}
