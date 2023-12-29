using FluentValidation;

namespace Application.Features.Categories.Queries.GetById;

public class GetByIdCategoryQueryValidator : AbstractValidator<GetByIdCategoryQuery>
{
    public GetByIdCategoryQueryValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}
