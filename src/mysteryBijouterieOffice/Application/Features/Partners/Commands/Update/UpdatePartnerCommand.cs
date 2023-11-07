using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Partners.Commands.Update;

public class UpdatePartnerCommand : IRequest<UpdatedPartnerResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public UpdatePartnerCommand()
    {
        Name = string.Empty;
    }

    public UpdatePartnerCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
