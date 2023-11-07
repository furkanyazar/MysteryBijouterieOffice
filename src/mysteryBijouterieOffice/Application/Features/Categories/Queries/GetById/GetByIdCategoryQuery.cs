using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Categories.Queries.GetById;

public class GetByIdCategoryQuery : IRequest<GetByIdCategoryResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public GetByIdCategoryQuery() { }

    public GetByIdCategoryQuery(int id)
    {
        Id = id;
    }
}
