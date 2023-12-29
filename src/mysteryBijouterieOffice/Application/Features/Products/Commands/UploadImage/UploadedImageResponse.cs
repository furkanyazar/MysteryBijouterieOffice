using Application.Features.Products.Commands.Update;
using Core.Application.Responses;

namespace Application.Features.Products.Commands.UploadImage;

public class UploadedImageResponse : IResponse
{
    public int Id { get; set; }
    public int? CategoryId { get; set; }
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SalePrice { get; set; }
    public string? CategoryName { get; set; }
    public string ModelNumber { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public int UnitsInStock { get; set; }
    public string StockCode { get; set; }
    public IList<UploadedImageResponseCategoryCategoryPartnerListItemDto> CategoryCategoryPartners { get; set; }
    public IList<UploadedImageResponseProductMaterialListItemDto> ProductMaterials { get; set; }

    public UploadedImageResponse()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
        CategoryCategoryPartners = new List<UploadedImageResponseCategoryCategoryPartnerListItemDto>();
        ProductMaterials = new List<UploadedImageResponseProductMaterialListItemDto>();
        StockCode = string.Empty;
    }

    public UploadedImageResponse(
        int id,
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal purchasePrice,
        decimal salePrice,
        string? categoryName,
        string modelNumber,
        string? ımageUrl,
        string? description,
        int unitsInStock,
        IList<UploadedImageResponseCategoryCategoryPartnerListItemDto> categoryCategoryPartners,
        IList<UploadedImageResponseProductMaterialListItemDto> productMaterials,
        string stockCode
    )
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        PurchasePrice = purchasePrice;
        SalePrice = salePrice;
        CategoryName = categoryName;
        ModelNumber = modelNumber;
        ImageUrl = ımageUrl;
        Description = description;
        UnitsInStock = unitsInStock;
        CategoryCategoryPartners = categoryCategoryPartners;
        ProductMaterials = productMaterials;
        StockCode = stockCode;
    }
}
