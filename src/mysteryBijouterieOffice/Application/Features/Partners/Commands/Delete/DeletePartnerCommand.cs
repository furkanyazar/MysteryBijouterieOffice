using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Partners.Commands.Delete;

public class DeletePartnerCommand : IRequest<DeletedPartnerResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public DeletePartnerCommand() { }

    public DeletePartnerCommand(int id)
    {
        Id = id;
    }
}
