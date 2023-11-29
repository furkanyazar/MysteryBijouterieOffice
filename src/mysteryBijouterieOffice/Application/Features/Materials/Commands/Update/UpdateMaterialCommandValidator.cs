using FluentValidation;

namespace Application.Features.Materials.Commands.Update;

public class UpdateMaterialCommandValidator : AbstractValidator<UpdateMaterialCommand>
{
    public UpdateMaterialCommandValidator()
    {
        RuleFor(m => m.Id).NotEmpty();
        RuleFor(m => m.Name).NotEmpty().MinimumLength(2);
        RuleFor(m => m.PurchasePrice).NotNull();
        RuleFor(m => m.UnitsInStock).NotNull();
    }
}
