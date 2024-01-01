using Application.Features.Discounts.Commands.Create;
using Application.Features.Discounts.Commands.Delete;
using Application.Features.Discounts.Commands.Update;
using Application.Features.Discounts.Queries.GetById;
using Application.Features.Discounts.Queries.GetList;
using Application.Features.Discounts.Queries.GetListByDynamic;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DiscountsController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListDiscountQuery getListDiscountQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListDiscountListItemDto> result = await Mediator.Send(getListDiscountQuery);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery dynamicQuery)
    {
        GetListByDynamicDiscountQuery getListByDynamicDiscountQuery = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicDiscountListItemDto> result = await Mediator.Send(getListByDynamicDiscountQuery);
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdDiscountQuery getByIdDiscountQuery)
    {
        GetByIdDiscountResponse result = await Mediator.Send(getByIdDiscountQuery);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteDiscountCommand deleteDiscountCommand)
    {
        DeletedDiscountResponse result = await Mediator.Send(deleteDiscountCommand);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateDiscountCommand createDiscountCommand)
    {
        CreatedDiscountResponse result = await Mediator.Send(createDiscountCommand);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateDiscountCommand updateDiscountCommand)
    {
        UpdatedDiscountResponse result = await Mediator.Send(updateDiscountCommand);
        return Ok(result);
    }
}
