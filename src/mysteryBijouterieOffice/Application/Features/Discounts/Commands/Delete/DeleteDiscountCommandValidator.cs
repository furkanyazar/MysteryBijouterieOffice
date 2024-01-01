using FluentValidation;

namespace Application.Features.Discounts.Commands.Delete;

public class DeleteDiscountCommandValidator : AbstractValidator<DeleteDiscountCommand>
{
    public DeleteDiscountCommandValidator()
    {
        RuleFor(d => d.Id).NotEmpty();
    }
}
