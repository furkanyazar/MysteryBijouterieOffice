using Core.Application.Responses;

namespace Application.Features.Partners.Queries.GetById;

public class GetByIdPartnerResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }

    public GetByIdPartnerResponse()
    {
        Name = string.Empty;
    }

    public GetByIdPartnerResponse(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
