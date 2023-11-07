using Core.Application.Dtos;

namespace Application.Features.Partners.Queries.GetListByDynamic;

public class GetListByDynamicPartnerListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public GetListByDynamicPartnerListItemDto()
    {
        Name = string.Empty;
    }

    public GetListByDynamicPartnerListItemDto(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
