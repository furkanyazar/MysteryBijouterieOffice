using Core.Application.Responses;

namespace Application.Features.Partners.Commands.Create;

public class CreatedPartnerResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }

    public CreatedPartnerResponse()
    {
        Name = string.Empty;
    }

    public CreatedPartnerResponse(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
