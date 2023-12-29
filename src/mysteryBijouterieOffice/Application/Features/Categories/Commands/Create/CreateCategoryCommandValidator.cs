using FluentValidation;

namespace Application.Features.Categories.Commands.Create;

public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().MinimumLength(2);
        RuleForEach(c => c.CategoryPartners).SetValidator(new CreateCategoryCommandCategoryPartnerListItemDtoValidator());
    }
}
