﻿using Core.Application.Responses;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductResponse : IResponse
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
    public bool Status { get; set; }
    public IList<GetByIdProductResponseCategoryCategoryPartnerListItemDto> CategoryCategoryPartners { get; set; }

    public GetByIdProductResponse()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
        ModelNumber = string.Empty;
        CategoryCategoryPartners = new List<GetByIdProductResponseCategoryCategoryPartnerListItemDto>();
    }

    public GetByIdProductResponse(
        int id,
        int? categoryId,
        string name,
        string barcodeNumber,
        decimal unitPrice,
        string? categoryName,
        string modelNumber,
        string? imageUrl,
        string description,
        bool status,
        IList<GetByIdProductResponseCategoryCategoryPartnerListItemDto> categoryCategoryPartners
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
        Status = status;
        CategoryCategoryPartners = categoryCategoryPartners;
    }
}
