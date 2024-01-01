using FluentValidation;

namespace Application.Features.Discounts.Queries.GetById;

public class GetByIdDiscountQueryValidator : AbstractValidator<GetByIdDiscountQuery>
{
    public GetByIdDiscountQueryValidator()
    {
        RuleFor(d => d.Id).NotEmpty();
    }
}
