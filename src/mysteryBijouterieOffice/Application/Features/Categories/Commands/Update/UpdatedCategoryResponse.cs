using Core.Application.Responses;

namespace Application.Features.Categories.Commands.Update;

public class UpdatedCategoryResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdatedCategoryResponse()
    {
        Name = string.Empty;
    }

    public UpdatedCategoryResponse(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
