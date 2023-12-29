using Application.Features.Partners.Commands.Create;
using Application.Features.Partners.Commands.Delete;
using Application.Features.Partners.Commands.Update;
using Application.Features.Partners.Queries.GetById;
using Application.Features.Partners.Queries.GetList;
using Application.Features.Partners.Queries.GetListByDynamic;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PartnersController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPartnerQuery getListPartnerQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListPartnerListItemDto> result = await Mediator.Send(getListPartnerQuery);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery dynamicQuery)
    {
        GetListByDynamicPartnerQuery getListByDynamicPartnerQuery = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicPartnerListItemDto> result = await Mediator.Send(getListByDynamicPartnerQuery);
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdPartnerQuery getByIdPartnerQuery)
    {
        GetByIdPartnerResponse result = await Mediator.Send(getByIdPartnerQuery);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeletePartnerCommand deletePartnerCommand)
    {
        DeletedPartnerResponse result = await Mediator.Send(deletePartnerCommand);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePartnerCommand createPartnerCommand)
    {
        CreatedPartnerResponse result = await Mediator.Send(createPartnerCommand);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePartnerCommand updatePartnerCommand)
    {
        UpdatedPartnerResponse result = await Mediator.Send(updatePartnerCommand);
        return Ok(result);
    }
}
