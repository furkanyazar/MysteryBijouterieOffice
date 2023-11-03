using Core.Application.Responses;

namespace Application.Features.Categories.Commands.Create;

public class CreatedCategoryResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal CommissionRate { get; set; }

    public CreatedCategoryResponse()
    {
        Name = string.Empty;
    }

    public CreatedCategoryResponse(int id, string name, decimal commissionRate)
    {
        Id = id;
        Name = name;
        CommissionRate = commissionRate;
    }
}
