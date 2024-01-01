using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Discounts.Queries.GetListByDynamic;

public class GetListByDynamicDiscountQuery : IRequest<GetListResponse<GetListByDynamicDiscountListItemDto>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; } = null!;
    public DynamicQuery DynamicQuery { get; set; } = null!;

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public GetListByDynamicDiscountQuery() { }

    public GetListByDynamicDiscountQuery(PageRequest pageRequest, DynamicQuery dynamicQuery)
    {
        PageRequest = pageRequest;
        DynamicQuery = dynamicQuery;
    }
}
