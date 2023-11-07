using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Partners.Commands.Create;

public class CreatePartnerCommand : IRequest<CreatedPartnerResponse>, ISecuredRequest
{
    public string Name { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public CreatePartnerCommand()
    {
        Name = string.Empty;
    }

    public CreatePartnerCommand(string name)
    {
        Name = name;
    }
}
