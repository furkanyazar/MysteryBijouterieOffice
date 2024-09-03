using FluentValidation;

namespace Application.Features.Products.Commands.Update;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty();
        RuleFor(p => p.CategoryId).GreaterThan(0).When(p => p.CategoryId != null);
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
        RuleFor(p => p.BarcodeNumber).NotEmpty();
        RuleFor(p => p.PurchasePrice).NotNull();
        RuleFor(p => p.ModelNumber).NotEmpty();
        RuleForEach(p => p.ProductMaterials).SetValidator(new UpdateProductCommandProductMaterialListItemDtoValidator());
        RuleFor(p => p.UnitsInStock).NotNull();
    }
}
