using FluentValidation;

namespace Application.Features.Partners.Commands.Delete;

public class DeletePartnerCommandValidator : AbstractValidator<DeletePartnerCommand>
{
    public DeletePartnerCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty();
    }
}
