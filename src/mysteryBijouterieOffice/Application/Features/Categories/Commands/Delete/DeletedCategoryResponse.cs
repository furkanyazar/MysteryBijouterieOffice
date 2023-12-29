using Core.Application.Responses;

namespace Application.Features.Categories.Commands.Delete;

public class DeletedCategoryResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<DeletedCategoryResponseCategoryPartnerListItemDto> CategoryPartners { get; set; }

    public DeletedCategoryResponse()
    {
        Name = string.Empty;
        CategoryPartners = new List<DeletedCategoryResponseCategoryPartnerListItemDto>();
    }

    public DeletedCategoryResponse(int id, string name, IList<DeletedCategoryResponseCategoryPartnerListItemDto> categoryPartners)
    {
        Id = id;
        Name = name;
        CategoryPartners = categoryPartners;
    }
}
