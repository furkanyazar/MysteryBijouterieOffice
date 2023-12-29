using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Materials.Queries.GetById;

public class GetByIdMaterialQuery : IRequest<GetByIdMaterialResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public GetByIdMaterialQuery() { }

    public GetByIdMaterialQuery(int id)
    {
        Id = id;
    }
}
