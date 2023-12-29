using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Categories.Queries.GetList;

public class GetListCategoryQuery : IRequest<GetListResponse<GetListCategoryListItemDto>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; } = null!;

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public GetListCategoryQuery() { }

    public GetListCategoryQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest;
    }
}
