using Core.Application.Pipelines.Authorization;
using Core.Security.Constants;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Features.Products.Commands.UploadImage;

public class UploadImageCommand : IRequest<UploadedImageResponse>, ISecuredRequest
{
    public int ProductId { get; set; }
    public IFormFile Image { get; set; } = null!;

    public string[] Roles => new string[] { GeneralOperationClaims.Admin };

    public UploadImageCommand() { }

    public UploadImageCommand(int productId, IFormFile image)
    {
        ProductId = productId;
        Image = image;
    }
}
