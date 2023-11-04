using Core.Application.Responses;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserResponse : IResponse
{
    public int Id { get; set; }
    public int UserGroupId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }
    public string UserGroupName { get; set; }

    public GetByIdUserResponse()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        UserGroupName = string.Empty;
    }

    public GetByIdUserResponse(int id, int userGroupId, string firstName, string lastName, string email, bool status, string userGroupName)
    {
        Id = id;
        UserGroupId = userGroupId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Status = status;
        UserGroupName = userGroupName;
    }
}
