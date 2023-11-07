using Core.Application.Responses;

namespace Application.Features.Partners.Commands.Delete;

public class DeletedPartnerResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }

    public DeletedPartnerResponse()
    {
        Name = string.Empty;
    }

    public DeletedPartnerResponse(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
