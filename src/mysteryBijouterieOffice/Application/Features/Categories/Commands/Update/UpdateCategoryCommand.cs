using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Categories.Commands.Update;

public class UpdateCategoryCommand : IRequest<UpdatedCategoryResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<UpdateCategoryCommandCategoryPartnerListItemDto> CategoryPartners { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public UpdateCategoryCommand()
    {
        Name = string.Empty;
        CategoryPartners = new List<UpdateCategoryCommandCategoryPartnerListItemDto>();
    }

    public UpdateCategoryCommand(int id, string name, IList<UpdateCategoryCommandCategoryPartnerListItemDto> categoryPartners)
    {
        Id = id;
        Name = name;
        CategoryPartners = categoryPartners;
    }
}
