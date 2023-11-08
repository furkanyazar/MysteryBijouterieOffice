using Core.Application.Dtos;

namespace Application.Features.Categories.Queries.GetList;

public class GetListCategoryListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<GetListCategoryCategoryPartnerListItemDto> CategoryPartners { get; set; }

    public GetListCategoryListItemDto()
    {
        Name = string.Empty;
        CategoryPartners = new List<GetListCategoryCategoryPartnerListItemDto>();
    }

    public GetListCategoryListItemDto(int id, string name, IList<GetListCategoryCategoryPartnerListItemDto> categoryPartners)
    {
        Id = id;
        Name = name;
        CategoryPartners = categoryPartners;
    }
}
