﻿using Core.Application.Responses;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductResponse : IResponse
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public GetByIdProductResponse()
    {
        Name = string.Empty;
    }

    public GetByIdProductResponse(int id, int categoryId, string name, string? barcodeNumber, decimal unitPrice)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}
