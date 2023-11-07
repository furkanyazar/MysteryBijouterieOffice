using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Partners.Queries.GetListByDynamic;

public class GetListByDynamicPartnerQuery : IRequest<GetListResponse<GetListByDynamicPartnerListItemDto>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; } = null!;
    public DynamicQuery DynamicQuery { get; set; } = null!;

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public GetListByDynamicPartnerQuery() { }

    public GetListByDynamicPartnerQuery(PageRequest pageRequest, DynamicQuery dynamicQuery)
    {
        PageRequest = pageRequest;
        DynamicQuery = dynamicQuery;
    }
}
