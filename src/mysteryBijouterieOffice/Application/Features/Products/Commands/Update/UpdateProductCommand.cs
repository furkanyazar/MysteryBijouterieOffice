using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Products.Commands.Update;

public class UpdateProductCommand : IRequest<UpdatedProductResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public int? CategoryId { get; set; }
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public string ModelNumber { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public UpdateProductCommand()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
    }

    public UpdateProductCommand(
        int id,
        int categoryId,
        string name,
        string barcodeNumber,
        decimal unitPrice,
        string modelNumber,
        string? description,
        bool status
    )
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
        ModelNumber = modelNumber;
        Description = description;
        Status = status;
    }
}
