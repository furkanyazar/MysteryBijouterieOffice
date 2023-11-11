﻿using Core.Application.Responses;

namespace Application.Features.Products.Commands.Delete;

public class DeletedProductResponse : IResponse
{
    public int Id { get; set; }
    public int? CategoryId { get; set; }
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public string? CategoryName { get; set; }
    public string ModelNumber { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public IList<DeletedProductResponseCategoryCategoryPartnerListItemDto> CategoryCategoryPartners { get; set; }

    public DeletedProductResponse()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
        CategoryCategoryPartners = new List<DeletedProductResponseCategoryCategoryPartnerListItemDto>();
    }

    public DeletedProductResponse(
        int id,
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal unitPrice,
        string? categoryName,
        string modelNumber,
        string? imageUrl,
        string description,
        IList<DeletedProductResponseCategoryCategoryPartnerListItemDto> categoryCategoryPartners
    )
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
        CategoryName = categoryName;
        ModelNumber = modelNumber;
        ImageUrl = imageUrl;
        Description = description;
        CategoryCategoryPartners = categoryCategoryPartners;
    }
}
