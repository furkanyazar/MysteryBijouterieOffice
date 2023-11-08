using Core.Application.Responses;

namespace Application.Features.Categories.Queries.GetById;

public class GetByIdCategoryResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<GetByIdCategoryResponseCategoryPartnerListItemDto> CategoryPartners { get; set; }

    public GetByIdCategoryResponse()
    {
        Name = string.Empty;
        CategoryPartners = new List<GetByIdCategoryResponseCategoryPartnerListItemDto>();
    }

    public GetByIdCategoryResponse(int id, string name, IList<GetByIdCategoryResponseCategoryPartnerListItemDto> categoryPartners)
    {
        Id = id;
        Name = name;
        CategoryPartners = categoryPartners;
    }
}
