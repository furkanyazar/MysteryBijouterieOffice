using Core.Application.Responses;

namespace Application.Features.Categories.Commands.Update;

public class UpdatedCategoryResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<UpdatedCategoryResponseCategoryPartnerListItemDto> CategoryPartners { get; set; }

    public UpdatedCategoryResponse()
    {
        Name = string.Empty;
        CategoryPartners = new List<UpdatedCategoryResponseCategoryPartnerListItemDto>();
    }

    public UpdatedCategoryResponse(int id, string name, IList<UpdatedCategoryResponseCategoryPartnerListItemDto> categoryPartners)
    {
        Id = id;
        Name = name;
        CategoryPartners = categoryPartners;
    }
}
