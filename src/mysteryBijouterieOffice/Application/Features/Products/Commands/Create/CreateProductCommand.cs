using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommand : IRequest<CreatedProductResponse>, ISecuredRequest
{
    public string Name { get; set; }
    public string BarcodeNumber { get; set; }
    public decimal UnitPrice { get; set; }

    public string[] Roles => new[] { GeneralOperationClaims.Admin };

    public CreateProductCommand()
    {
        Name = string.Empty;
        BarcodeNumber = string.Empty;
    }

    public CreateProductCommand(string name, string barcodeNumber, decimal unitPrice)
    {
        Name = name;
        BarcodeNumber = barcodeNumber;
        UnitPrice = unitPrice;
    }
}
