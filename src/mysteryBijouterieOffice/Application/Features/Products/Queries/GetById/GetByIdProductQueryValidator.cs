using FluentValidation;

namespace Application.Features.Products.Queries.GetById;

public class GetByIdProductQueryValidator : AbstractValidator<GetByIdProductQuery>
{
    public GetByIdProductQueryValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}
