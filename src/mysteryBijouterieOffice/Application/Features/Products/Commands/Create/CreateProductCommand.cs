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
    public int UnitsInStock { get; set; }
    public string StockCode { get; set; }
    public IList<CreateProductCommandProductMaterialListItemDto> ProductMaterials { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public CreateProductCommand()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
        ProductMaterials = new List<CreateProductCommandProductMaterialListItemDto>();
        StockCode = string.Empty;
    }

    public CreateProductCommand(
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal purchasePrice,
        string modelNumber,
        string? description,
        int unitsInStock,
        IList<CreateProductCommandProductMaterialListItemDto> productMaterials,
        string stockCode
    )
    {
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        PurchasePrice = purchasePrice;
        ModelNumber = modelNumber;
        Description = description;
        UnitsInStock = unitsInStock;
        ProductMaterials = productMaterials;
        StockCode = stockCode;
    }
}
