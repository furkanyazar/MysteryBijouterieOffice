using Application.Features.Products.Rules;
using Application.Services.ImageService;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Commands.UploadImage;

public class UploadImageCommandHandler : IRequestHandler<UploadImageCommand, UploadedImageResponse>
{
    private readonly IProductRepository _productRepository;
    private readonly ImageServiceBase _imageService;
    private readonly ProductBusinessRules _productBusinessRules;
    private readonly IMapper _mapper;

    public UploadImageCommandHandler(
        IProductRepository productRepository,
        ImageServiceBase imageService,
        ProductBusinessRules productBusinessRules,
        IMapper mapper
    )
    {
        _productRepository = productRepository;
        _imageService = imageService;
        _productBusinessRules = productBusinessRules;
        _mapper = mapper;
    }

    public async Task<UploadedImageResponse> Handle(UploadImageCommand request, CancellationToken cancellationToken)
    {
        Product? product = await _productRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);

        await _productBusinessRules.ProductShouldExistWhenSelected(product);

        string imageUrl = await _imageService.UploadAsync(request.Image);
        product!.ImageUrl = imageUrl.Replace("http://", "https://");

        Product updatedProduct = await _productRepository.UpdateAsync(product);
        UploadedImageResponse response = _mapper.Map<UploadedImageResponse>(updatedProduct);
        return response;
    }
}
