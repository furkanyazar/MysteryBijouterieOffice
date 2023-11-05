﻿using Core.Application.Responses;

namespace Application.Features.Products.Commands.Update;

public class UpdatedProductResponse : IResponse
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public string CategoryName { get; set; }

    public UpdatedProductResponse()
    {
        Name = string.Empty;
        CategoryName = string.Empty;
    }

    public UpdatedProductResponse(int id, int categoryId, string name, string? barcodeNumber, decimal unitPrice, string categoryName)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
        CategoryName = categoryName;
    }
}