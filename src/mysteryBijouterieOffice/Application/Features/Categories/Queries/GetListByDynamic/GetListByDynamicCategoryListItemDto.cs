using Core.Application.Dtos;

namespace Application.Features.Categories.Queries.GetListByDynamic;

public class GetListByDynamicCategoryListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public GetListByDynamicCategoryListItemDto()
    {
        Name = string.Empty;
    }

    public GetListByDynamicCategoryListItemDto(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
