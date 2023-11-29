using FluentValidation;

namespace Application.Features.Materials.Commands.Create;

public class CreateMaterialCommandValidator : AbstractValidator<CreateMaterialCommand>
{
    public CreateMaterialCommandValidator()
    {
        RuleFor(m => m.Name).NotEmpty().MinimumLength(2);
        RuleFor(m => m.PurchasePrice).NotNull();
        RuleFor(m => m.UnitsInStock).NotNull();
    }
}
