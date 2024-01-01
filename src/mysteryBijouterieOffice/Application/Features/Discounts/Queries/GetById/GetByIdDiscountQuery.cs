using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Discounts.Queries.GetById;

public class GetByIdDiscountQuery : IRequest<GetByIdDiscountResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public GetByIdDiscountQuery() { }

    public GetByIdDiscountQuery(int id)
    {
        Id = id;
    }
}
