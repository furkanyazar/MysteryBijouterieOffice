using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Categories.Queries.GetListByDynamic;

public class GetListByDynamicCategoryQuery : IRequest<GetListResponse<GetListByDynamicCategoryListItemDto>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; } = null!;
    public DynamicQuery DynamicQuery { get; set; } = null!;

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public GetListByDynamicCategoryQuery() { }

    public GetListByDynamicCategoryQuery(PageRequest pageRequest, DynamicQuery dynamicQuery)
    {
        PageRequest = pageRequest;
        DynamicQuery = dynamicQuery;
    }
}
