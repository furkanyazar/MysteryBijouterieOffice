using Core.Application.Dtos;

namespace Application.Features.Partners.Queries.GetList;

public class GetListPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public GetListPartnerListItemDto()
    {
        Name = string.Empty;
    }

    public GetListPartnerListItemDto(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
