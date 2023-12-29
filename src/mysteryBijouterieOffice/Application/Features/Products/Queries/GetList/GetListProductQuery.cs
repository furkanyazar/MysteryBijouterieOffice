using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Products.Queries.GetList;

public class GetListProductQuery : IRequest<GetListResponse<GetListProductListItemDto>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; } = null!;

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public GetListProductQuery() { }

    public GetListProductQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest;
    }
}
