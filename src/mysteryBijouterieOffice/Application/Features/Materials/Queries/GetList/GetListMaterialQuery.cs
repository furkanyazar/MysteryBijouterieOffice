using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Materials.Queries.GetList;

public class GetListMaterialQuery : IRequest<GetListResponse<GetListMaterialListItemDto>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; } = null!;

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public GetListMaterialQuery() { }

    public GetListMaterialQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest;
    }
}
