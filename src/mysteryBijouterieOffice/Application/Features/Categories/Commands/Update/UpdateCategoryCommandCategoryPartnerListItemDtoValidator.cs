using FluentValidation;

namespace Application.Features.Categories.Commands.Update;

public class UpdateCategoryCommandCategoryPartnerListItemDtoValidator : AbstractValidator<UpdateCategoryCommandCategoryPartnerListItemDto>
{
    public UpdateCategoryCommandCategoryPartnerListItemDtoValidator()
    {
        RuleFor(c => c.Id).NotNull();
        RuleFor(c => c.PartnerId).NotEmpty();
        RuleFor(c => c.CommissionRate).NotNull();
    }
}
