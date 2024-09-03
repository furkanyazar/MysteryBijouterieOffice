using FluentValidation;

namespace Application.Features.Products.Commands.Create;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.CategoryId).GreaterThan(0).When(p => p.CategoryId != null);
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
        RuleFor(p => p.BarcodeNumber).NotEmpty();
        RuleFor(p => p.PurchasePrice).NotNull();
        RuleFor(p => p.ModelNumber).NotEmpty();
        RuleForEach(p => p.ProductMaterials).SetValidator(new CreateProductCommandProductMaterialListItemDtoValidator());
        RuleFor(p => p.UnitsInStock).NotNull();
    }
}
