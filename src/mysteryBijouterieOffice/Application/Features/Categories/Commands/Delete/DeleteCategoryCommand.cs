using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Categories.Commands.Delete;

public class DeleteCategoryCommand : IRequest<DeletedCategoryResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public DeleteCategoryCommand() { }

    public DeleteCategoryCommand(int id)
    {
        Id = id;
    }
}
