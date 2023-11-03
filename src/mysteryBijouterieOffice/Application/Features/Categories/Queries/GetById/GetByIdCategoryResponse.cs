using Core.Application.Responses;

namespace Application.Features.Categories.Queries.GetById;

public class GetByIdCategoryResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal CommissionRate { get; set; }

    public GetByIdCategoryResponse()
    {
        Name = string.Empty;
    }

    public GetByIdCategoryResponse(int id, string name, decimal commissionRate)
    {
        Id = id;
        Name = name;
        CommissionRate = commissionRate;
    }
}
