using Core.Application.Dtos;

namespace Application.Features.Products.Queries.GetList;

public class GetListProductListItemDto : IDto
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
    public IList<GetListProductCategoryCategoryPartnerListItemDto> CategoryCategoryPartners { get; set; }
    public IList<GetListProductProductMaterialListItemDto> ProductMaterials { get; set; }

    public GetListProductListItemDto()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
        CategoryCategoryPartners = new List<GetListProductCategoryCategoryPartnerListItemDto>();
        ProductMaterials = new List<GetListProductProductMaterialListItemDto>();
    }

    public GetListProductListItemDto(
        int id,
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal purchasePrice,
        decimal salePrice,
        string? categoryName,
        string modelNumber,
        string? imageUrl,
        string? description,
        bool status,
        IList<GetListProductCategoryCategoryPartnerListItemDto> categoryCategoryPartners,
        IList<GetListProductProductMaterialListItemDto> productMaterials
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
