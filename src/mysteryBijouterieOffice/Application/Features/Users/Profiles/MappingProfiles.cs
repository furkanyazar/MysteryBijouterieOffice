using Application.Features.Users.Queries.GetById;
using AutoMapper;
using Core.Security.Entities;

namespace Application.Features.Users.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, GetByIdUserResponse>().ReverseMap();
    }
}
