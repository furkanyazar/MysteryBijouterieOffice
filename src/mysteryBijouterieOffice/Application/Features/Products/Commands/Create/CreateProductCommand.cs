﻿using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommand : IRequest<CreatedProductResponse>, ISecuredRequest
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string? BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public CreateProductCommand()
    {
        Name = string.Empty;
    }

    public CreateProductCommand(int categoryId, string name, string? barcodeNumber, decimal unitPrice)
    {
        CategoryId = categoryId;
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}