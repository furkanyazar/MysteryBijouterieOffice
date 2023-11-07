using Core.Application.Dtos;

namespace Application.Features.Categories.Queries.GetList;

public class GetListCategoryListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public GetListCategoryListItemDto()
    {
        Name = string.Empty;
    }

    public GetListCategoryListItemDto(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
