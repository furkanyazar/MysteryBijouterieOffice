using Application.Features.Products.Commands.Create;
using Application.Features.Products.Commands.Delete;
using Application.Features.Products.Commands.Update;
using Application.Features.Products.Commands.UploadImage;
using Application.Features.Products.Queries.GetById;
using Application.Features.Products.Queries.GetList;
using Application.Features.Products.Queries.GetListByDynamic;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListProductQuery getListProductQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListProductListItemDto> result = await Mediator.Send(getListProductQuery);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery dynamicQuery)
    {
        GetListByDynamicProductQuery getListByDynamicProductQuery = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicProductListItemDto> result = await Mediator.Send(getListByDynamicProductQuery);
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdProductQuery getByIdProductQuery)
    {
        GetByIdProductResponse result = await Mediator.Send(getByIdProductQuery);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductCommand deleteProductCommand)
    {
        DeletedProductResponse result = await Mediator.Send(deleteProductCommand);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductCommand createProductCommand)
    {
        CreatedProductResponse result = await Mediator.Send(createProductCommand);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductCommand updateProductCommand)
    {
        UpdatedProductResponse result = await Mediator.Send(updateProductCommand);
        return Ok(result);
    }

    [HttpPost("[action]/{productId}")]
    public async Task<IActionResult> UploadImage([FromRoute] int productId, IFormFile image)
    {
        UploadImageCommand uploadImageCommand = new() { ProductId = productId, Image = image };
        UploadedImageResponse result = await Mediator.Send(uploadImageCommand);
        return Ok(result);
    }
}
