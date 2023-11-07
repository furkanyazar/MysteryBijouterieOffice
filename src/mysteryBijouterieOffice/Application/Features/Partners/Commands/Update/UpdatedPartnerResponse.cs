using Core.Application.Responses;

namespace Application.Features.Partners.Commands.Update;

public class UpdatedPartnerResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdatedPartnerResponse()
    {
        Name = string.Empty;
    }

    public UpdatedPartnerResponse(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
