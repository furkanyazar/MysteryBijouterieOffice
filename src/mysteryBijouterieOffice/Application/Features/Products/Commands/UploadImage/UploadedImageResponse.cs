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
    public bool Status { get; set; }
    public IList<UploadedImageResponseCategoryCategoryPartnerListItemDto> CategoryCategoryPartners { get; set; }

    public UploadedImageResponse()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
        CategoryCategoryPartners = new List<UploadedImageResponseCategoryCategoryPartnerListItemDto>();
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
        bool status,
        IList<UploadedImageResponseCategoryCategoryPartnerListItemDto> categoryCategoryPartners
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
        Status = status;
        CategoryCategoryPartners = categoryCategoryPartners;
    }
}
