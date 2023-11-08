using FluentValidation;

namespace Application.Features.Categories.Commands.Create;

public class CreateCategoryCommandCategoryPartnerListItemDtoValidator : AbstractValidator<CreateCategoryCommandCategoryPartnerListItemDto>
{
    public CreateCategoryCommandCategoryPartnerListItemDtoValidator()
    {
        RuleFor(c => c.PartnerId).NotEmpty();
        RuleFor(c => c.CommissionRate).NotNull();
    }
}
