using Application.Features.Users.Constants;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Security.Entities;

namespace Application.Features.Users.Rules;

public class UserBusinessRules : BaseBusinessRules
{
    public Task UserShouldExistWhenSelected(User? product)
    {
        if (product is null)
            throw new NotFoundException(UsersMessages.UserNotExists);
        return Task.CompletedTask;
    }
}
