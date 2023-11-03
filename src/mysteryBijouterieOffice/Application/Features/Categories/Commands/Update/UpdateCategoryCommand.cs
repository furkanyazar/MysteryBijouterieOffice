using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Categories.Commands.Update;

public class UpdateCategoryCommand : IRequest<UpdatedCategoryResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal CommissionRate { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public UpdateCategoryCommand()
    {
        Name = string.Empty;
    }

    public UpdateCategoryCommand(int id, string name, decimal commissionRate)
    {
        Id = id;
        Name = name;
        CommissionRate = commissionRate;
    }
}
