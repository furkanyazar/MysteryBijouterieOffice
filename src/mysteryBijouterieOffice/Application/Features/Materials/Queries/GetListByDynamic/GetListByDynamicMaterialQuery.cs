using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Materials.Queries.GetListByDynamic;

public class GetListByDynamicMaterialQuery : IRequest<GetListResponse<GetListByDynamicMaterialListItemDto>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; } = null!;
    public DynamicQuery DynamicQuery { get; set; } = null!;

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public GetListByDynamicMaterialQuery() { }

    public GetListByDynamicMaterialQuery(PageRequest pageRequest, DynamicQuery dynamicQuery)
    {
        PageRequest = pageRequest;
        DynamicQuery = dynamicQuery;
    }
}
