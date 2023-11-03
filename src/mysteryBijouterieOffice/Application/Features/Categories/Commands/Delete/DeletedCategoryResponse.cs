using Core.Application.Responses;

namespace Application.Features.Categories.Commands.Delete;

public class DeletedCategoryResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal CommissionRate { get; set; }

    public DeletedCategoryResponse()
    {
        Name = string.Empty;
    }

    public DeletedCategoryResponse(int id, string name, decimal commissionRate)
    {
        Id = id;
        Name = name;
        CommissionRate = commissionRate;
    }
}
