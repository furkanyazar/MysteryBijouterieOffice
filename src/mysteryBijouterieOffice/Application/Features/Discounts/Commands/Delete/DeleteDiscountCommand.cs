using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Discounts.Commands.Delete;

public class DeleteDiscountCommand : IRequest<DeletedDiscountResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public DeleteDiscountCommand() { }

    public DeleteDiscountCommand(int id)
    {
        Id = id;
    }
}
