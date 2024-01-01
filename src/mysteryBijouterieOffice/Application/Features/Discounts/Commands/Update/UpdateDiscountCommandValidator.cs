using FluentValidation;

namespace Application.Features.Discounts.Commands.Update;

public class UpdateDiscountCommandValidator : AbstractValidator<UpdateDiscountCommand>
{
    public UpdateDiscountCommandValidator()
    {
        RuleFor(d => d.Id).NotEmpty();
        RuleFor(d => d.PartnerId).NotEmpty();
        RuleFor(d => d.Name).NotEmpty().MinimumLength(2);
        RuleFor(d => d.DiscountType).NotEmpty();
        RuleFor(d => d.DiscountAmount).NotEmpty();
    }
}
