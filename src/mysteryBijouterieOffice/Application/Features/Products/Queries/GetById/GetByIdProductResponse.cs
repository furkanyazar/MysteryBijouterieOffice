using Core.Application.Responses;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductResponse : IResponse
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
    public IList<GetByIdProductResponseCategoryCategoryPartnerListItemDto> CategoryCategoryPartners { get; set; }
    public IList<GetByIdProductResponseProductMaterialListItemDto> ProductMaterials { get; set; }

    public GetByIdProductResponse()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
        CategoryCategoryPartners = new List<GetByIdProductResponseCategoryCategoryPartnerListItemDto>();
        ProductMaterials = new List<GetByIdProductResponseProductMaterialListItemDto>();
        StockCode = string.Empty;
    }

    public GetByIdProductResponse(
        int id,
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal purchasePrice,
        decimal salePrice,
        string? categoryName,
        string modelNumber,
        string? imageUrl,
        string description,
        int unitsInStock,
        IList<GetByIdProductResponseCategoryCategoryPartnerListItemDto> categoryCategoryPartners,
        IList<GetByIdProductResponseProductMaterialListItemDto> productMaterials,
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
        ImageUrl = imageUrl;
        Description = description;
        UnitsInStock = unitsInStock;
        CategoryCategoryPartners = categoryCategoryPartners;
        ProductMaterials = productMaterials;
        StockCode = stockCode;
    }
}
