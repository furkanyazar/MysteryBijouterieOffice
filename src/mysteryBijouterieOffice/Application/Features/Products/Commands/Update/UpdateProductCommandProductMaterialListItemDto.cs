using Core.Application.Dtos;

namespace Application.Features.Products.Commands.Update;

public class UpdateProductCommandProductMaterialListItemDto : IDto
{
    public int MaterialId { get; set; }

    public UpdateProductCommandProductMaterialListItemDto() { }

    public UpdateProductCommandProductMaterialListItemDto(int materialId)
    {
        MaterialId = materialId;
    }
}
