using Core.Application.Responses;

namespace Application.Features.Products.Commands.UploadImage;

public class UploadedImageResponse : IResponse
{
    public int ProductId { get; set; }
    public string? ImageUrl { get; set; }

    public UploadedImageResponse() { }

    public UploadedImageResponse(int productId, string? imageUrl)
    {
        ProductId = productId;
        ImageUrl = imageUrl;
    }
}
