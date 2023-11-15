using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommand : IRequest<CreatedProductResponse>, ISecuredRequest
{
    public int? CategoryId { get; set; }
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal PurchasePrice { get; set; }
    public string ModelNumber { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public CreateProductCommand()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
    }

    public CreateProductCommand(
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal purchasePrice,
        string modelNumber,
        string? description,
        bool status
    )
    {
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        PurchasePrice = purchasePrice;
        ModelNumber = modelNumber;
        Description = description;
        Status = status;
    }
}
