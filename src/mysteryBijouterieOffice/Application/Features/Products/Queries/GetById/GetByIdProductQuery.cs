using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductQuery : IRequest<GetByIdProductResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public GetByIdProductQuery() { }

    public GetByIdProductQuery(int id)
    {
        Id = id;
    }
}
