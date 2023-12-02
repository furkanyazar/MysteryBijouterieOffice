using FluentValidation;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommandProductMaterialListItemDtoValidator : AbstractValidator<CreateProductCommandProductMaterialListItemDto>
{
    public CreateProductCommandProductMaterialListItemDtoValidator()
    {
        RuleFor(pm => pm.MaterialId).NotEmpty();
    }
}
