using FluentValidation;

namespace Application.Features.Partners.Commands.Create;

public class CreatePartnerCommandValidator : AbstractValidator<CreatePartnerCommand>
{
    public CreatePartnerCommandValidator()
    {
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
    }
}
