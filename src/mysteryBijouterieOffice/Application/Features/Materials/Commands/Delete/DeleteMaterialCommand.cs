using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Materials.Commands.Delete;

public class DeleteMaterialCommand : IRequest<DeletedMaterialResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public DeleteMaterialCommand() { }

    public DeleteMaterialCommand(int id)
    {
        Id = id;
    }
}
