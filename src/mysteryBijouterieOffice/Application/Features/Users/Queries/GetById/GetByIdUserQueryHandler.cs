using Application.Features.Users.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Security.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, GetByIdUserResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly UserBusinessRules _userBusinessRules;

    public GetByIdUserQueryHandler(IUserRepository userRepository, IMapper mapper, UserBusinessRules userBusinessRules)
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _userBusinessRules = userBusinessRules;
    }

    public async Task<GetByIdUserResponse> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetAsync(
            predicate: u => u.Id == request.Id,
            include: c => c.Include(u => u.UserGroup),
            cancellationToken: cancellationToken
        );

        await _userBusinessRules.UserShouldExistWhenSelected(user);

        GetByIdUserResponse response = _mapper.Map<GetByIdUserResponse>(user);
        return response;
    }
}
