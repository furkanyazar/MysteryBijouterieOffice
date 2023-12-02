using Core.Application.Dtos;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommandProductMaterialListItemDto : IDto
{
    public int MaterialId { get; set; }

    public CreateProductCommandProductMaterialListItemDto() { }

    public CreateProductCommandProductMaterialListItemDto(int materialId)
    {
        MaterialId = materialId;
    }
}
