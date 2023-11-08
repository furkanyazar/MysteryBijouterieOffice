using Core.Application.Responses;

namespace Application.Features.Categories.Commands.Create;

public class CreatedCategoryResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<CreatedCategoryResponseCategoryPartnerListItemDto> CategoryPartners { get; set; }

    public CreatedCategoryResponse()
    {
        Name = string.Empty;
        CategoryPartners = new List<CreatedCategoryResponseCategoryPartnerListItemDto>();
    }

    public CreatedCategoryResponse(int id, string name, IList<CreatedCategoryResponseCategoryPartnerListItemDto> categoryPartners)
    {
        Id = id;
        Name = name;
        CategoryPartners = categoryPartners;
    }
}
