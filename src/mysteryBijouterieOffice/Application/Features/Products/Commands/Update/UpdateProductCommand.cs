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
    public decimal PurchasePrice { get; set; }
    public string ModelNumber { get; set; }
    public string? Description { get; set; }
    public int UnitsInStock { get; set; }
    public string? StockCode { get; set; }
    public IList<UpdateProductCommandProductMaterialListItemDto> ProductMaterials { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public UpdateProductCommand()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
        ProductMaterials = new List<UpdateProductCommandProductMaterialListItemDto>();
    }

    public UpdateProductCommand(
        int id,
        int categoryId,
        string name,
        string barcodeNumber,
        decimal purchasePrice,
        string modelNumber,
        string? description,
        int unitsInStock,
        IList<UpdateProductCommandProductMaterialListItemDto> productMaterials,
        string? stockCode
    )
    {
        Id = id;
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
