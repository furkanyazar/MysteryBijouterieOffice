using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Categories.Commands.Create;

public class CreateCategoryCommand : IRequest<CreatedCategoryResponse>, ISecuredRequest
{
    public string Name { get; set; }
    public IList<CreateCategoryCommandCategoryPartnerListItemDto> CategoryPartners { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public CreateCategoryCommand()
    {
        Name = string.Empty;
        CategoryPartners = new List<CreateCategoryCommandCategoryPartnerListItemDto>();
    }

    public CreateCategoryCommand(string name, IList<CreateCategoryCommandCategoryPartnerListItemDto> categoryPartners)
    {
        Name = name;
        CategoryPartners = categoryPartners;
    }
}
