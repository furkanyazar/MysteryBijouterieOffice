using FluentValidation;

namespace Application.Features.Products.Commands.Update;

public class UpdateProductCommandProductMaterialListItemDtoValidator : AbstractValidator<UpdateProductCommandProductMaterialListItemDto>
{
    public UpdateProductCommandProductMaterialListItemDtoValidator()
    {
        RuleFor(pm => pm.MaterialId).NotEmpty();
    }
}
