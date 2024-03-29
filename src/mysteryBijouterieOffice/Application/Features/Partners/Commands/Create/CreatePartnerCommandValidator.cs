﻿using FluentValidation;

namespace Application.Features.Partners.Commands.Create;

public class CreatePartnerCommandValidator : AbstractValidator<CreatePartnerCommand>
{
    public CreatePartnerCommandValidator()
    {
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
        RuleFor(p => p.ShippingCost).NotNull();
        RuleFor(p => p.ServiceFee).NotNull();
        RuleFor(p => p.TransactionFee).NotNull();
    }
}
