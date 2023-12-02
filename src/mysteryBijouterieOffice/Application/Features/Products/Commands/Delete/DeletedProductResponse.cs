using Core.Application.Responses;

namespace Application.Features.Products.Commands.Delete;

public class DeletedProductResponse : IResponse
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
    public bool Status { get; set; }
    public IList<DeletedProductResponseCategoryCategoryPartnerListItemDto> CategoryCategoryPartners { get; set; }
    public IList<DeletedProductResponseProductMaterialListItemDto> ProductMaterials { get; set; }

    public DeletedProductResponse()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
        CategoryCategoryPartners = new List<DeletedProductResponseCategoryCategoryPartnerListItemDto>();
        ProductMaterials = new List<DeletedProductResponseProductMaterialListItemDto>();
    }

    public DeletedProductResponse(
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
        bool status,
        IList<DeletedProductResponseCategoryCategoryPartnerListItemDto> categoryCategoryPartners,
        IList<DeletedProductResponseProductMaterialListItemDto> productMaterials
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
        Status = status;
        CategoryCategoryPartners = categoryCategoryPartners;
        ProductMaterials = productMaterials;
    }
}
