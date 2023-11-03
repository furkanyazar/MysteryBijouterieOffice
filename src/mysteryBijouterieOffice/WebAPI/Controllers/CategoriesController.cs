using Application.Features.Categories.Commands.Create;
using Application.Features.Categories.Commands.Delete;
using Application.Features.Categories.Commands.Update;
using Application.Features.Categories.Queries.GetById;
using Application.Features.Categories.Queries.GetList;
using Application.Features.Categories.Queries.GetListByDynamic;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListCategoryQuery getListCategoryQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListCategoryListItemDto> result = await Mediator.Send(getListCategoryQuery);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery dynamicQuery)
    {
        GetListByDynamicCategoryQuery getListByDynamicCategoryQuery = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicCategoryListItemDto> result = await Mediator.Send(getListByDynamicCategoryQuery);
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdCategoryQuery getByIdCategoryQuery)
    {
        GetByIdCategoryResponse result = await Mediator.Send(getByIdCategoryQuery);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteCategoryCommand deleteCategoryCommand)
    {
        DeletedCategoryResponse result = await Mediator.Send(deleteCategoryCommand);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCategoryCommand createCategoryCommand)
    {
        CreatedCategoryResponse result = await Mediator.Send(createCategoryCommand);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCategoryCommand updateCategoryCommand)
    {
        UpdatedCategoryResponse result = await Mediator.Send(updateCategoryCommand);
        return Ok(result);
    }
}
