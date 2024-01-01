using FluentValidation;

namespace Application.Features.Discounts.Commands.Create;

public class CreateDiscountCommandValidator : AbstractValidator<CreateDiscountCommand>
{
    public CreateDiscountCommandValidator()
    {
        RuleFor(d => d.PartnerId).NotEmpty();
        RuleFor(d => d.Name).NotEmpty().MinimumLength(2);
        RuleFor(d => d.DiscountType).NotEmpty();
        RuleFor(d => d.DiscountAmount).NotEmpty();
    }
}
