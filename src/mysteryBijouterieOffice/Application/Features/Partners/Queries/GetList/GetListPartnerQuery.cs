using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Partners.Queries.GetList;

public class GetListPartnerQuery : IRequest<GetListResponse<GetListPartnerListItemDto>>, ISecuredRequest
{
    public PageRequest PageRequest { get; set; } = null!;

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public GetListPartnerQuery() { }

    public GetListPartnerQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest;
    }
}
