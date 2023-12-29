using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Partners.Queries.GetById;

public class GetByIdPartnerQuery : IRequest<GetByIdPartnerResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public GetByIdPartnerQuery() { }

    public GetByIdPartnerQuery(int id)
    {
        Id = id;
    }
}
