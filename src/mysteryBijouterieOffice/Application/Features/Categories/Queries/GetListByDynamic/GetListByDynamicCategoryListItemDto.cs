using Core.Application.Dtos;

namespace Application.Features.Categories.Queries.GetListByDynamic;

public class GetListByDynamicCategoryListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<GetListByDynamicCategoryCategoryPartnerListItemDto> CategoryPartners { get; set; }

    public GetListByDynamicCategoryListItemDto()
    {
        Name = string.Empty;
        CategoryPartners = new List<GetListByDynamicCategoryCategoryPartnerListItemDto>();
    }

    public GetListByDynamicCategoryListItemDto(
        int id,
        string name,
        IList<GetListByDynamicCategoryCategoryPartnerListItemDto> categoryPartners
    )
    {
        Id = id;
        Name = name;
        CategoryPartners = categoryPartners;
    }
}
