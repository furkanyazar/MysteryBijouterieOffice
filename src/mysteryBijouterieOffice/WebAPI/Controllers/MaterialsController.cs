using Application.Features.Materials.Commands.Create;
using Application.Features.Materials.Commands.Delete;
using Application.Features.Materials.Commands.Update;
using Application.Features.Materials.Queries.GetById;
using Application.Features.Materials.Queries.GetList;
using Application.Features.Materials.Queries.GetListByDynamic;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MaterialsController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListMaterialQuery getListMaterialQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListMaterialListItemDto> result = await Mediator.Send(getListMaterialQuery);
        return Ok(result);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery dynamicQuery)
    {
        GetListByDynamicMaterialQuery getListByDynamicMaterialQuery = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicMaterialListItemDto> result = await Mediator.Send(getListByDynamicMaterialQuery);
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdMaterialQuery getByIdMaterialQuery)
    {
        GetByIdMaterialResponse result = await Mediator.Send(getByIdMaterialQuery);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteMaterialCommand deleteMaterialCommand)
    {
        DeletedMaterialResponse result = await Mediator.Send(deleteMaterialCommand);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateMaterialCommand createMaterialCommand)
    {
        CreatedMaterialResponse result = await Mediator.Send(createMaterialCommand);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateMaterialCommand updateMaterialCommand)
    {
        UpdatedMaterialResponse result = await Mediator.Send(updateMaterialCommand);
        return Ok(result);
    }
}
