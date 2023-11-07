using Core.Application.Responses;

namespace Application.Features.Categories.Commands.Delete;

public class DeletedCategoryResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }

    public DeletedCategoryResponse()
    {
        Name = string.Empty;
    }

    public DeletedCategoryResponse(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
