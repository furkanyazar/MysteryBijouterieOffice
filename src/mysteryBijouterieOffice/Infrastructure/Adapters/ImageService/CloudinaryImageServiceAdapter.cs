using Application.Services.ImageService;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Adapters.ImageService;

public class CloudinaryImageServiceAdapter : ImageServiceBase
{
    private readonly Cloudinary _cloudinary;

    public CloudinaryImageServiceAdapter(IConfiguration configuration)
    {
        const string cloudinaryOptionsConfigurationSection = "CloudinaryAccount";
        Account account =
            configuration.GetSection(cloudinaryOptionsConfigurationSection).Get<Account>()
            ?? throw new NullReferenceException($"\"{cloudinaryOptionsConfigurationSection}\" section cannot found in configuration");
        _cloudinary = new Cloudinary(account);
    }

    public override async Task<string> UploadAsync(IFormFile formFile)
    {
        await FileMustBeInImageFormat(formFile);

        ImageUploadParams imageUploadParams =
            new()
            {
                File = new FileDescription(formFile.FileName, stream: formFile.OpenReadStream()),
                UseFilename = false,
                UniqueFilename = true,
                Overwrite = false
            };
        ImageUploadResult imageUploadResult = await _cloudinary.UploadAsync(imageUploadParams);

        return imageUploadResult.Url.ToString();
    }

    public override async Task DeleteAsync(string imageUrl)
    {
        DeletionParams deletionParams = new(GetPublicId(imageUrl));
        await _cloudinary.DestroyAsync(deletionParams);
    }

    private string GetPublicId(string imageUrl)
    {
        int startIndex = imageUrl.LastIndexOf('/') + 1;
        int endIndex = imageUrl.LastIndexOf('.');
        int length = endIndex - startIndex;
        return imageUrl.Substring(startIndex, length);
    }
}
