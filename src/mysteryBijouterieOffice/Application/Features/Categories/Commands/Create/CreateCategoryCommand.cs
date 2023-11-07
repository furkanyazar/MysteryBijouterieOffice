using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Categories.Commands.Create;

public class CreateCategoryCommand : IRequest<CreatedCategoryResponse>, ISecuredRequest
{
    public string Name { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public CreateCategoryCommand()
    {
        Name = string.Empty;
    }

    public CreateCategoryCommand(string name)
    {
        Name = name;
    }
}
