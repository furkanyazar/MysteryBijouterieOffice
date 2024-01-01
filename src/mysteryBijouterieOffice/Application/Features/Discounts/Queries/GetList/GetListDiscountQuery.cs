using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Discounts.Queries.GetList;

public class GetListDiscountQuery : IRequest<GetListResponse<GetListDiscountListItemDto>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; } = null!;

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public GetListDiscountQuery() { }

    public GetListDiscountQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest;
    }
}
