using FluentValidation;

namespace Application.Features.Partners.Commands.Update;

public class UpdatePartnerCommandValidator : AbstractValidator<UpdatePartnerCommand>
{
    public UpdatePartnerCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty();
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
        RuleFor(p => p.ShippingCost).NotNull();
        RuleFor(p => p.ServiceFee).NotNull();
    }
}
