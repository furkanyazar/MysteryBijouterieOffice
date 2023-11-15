using FluentValidation;

namespace Application.Features.Products.Commands.UpdateSalePrice;

public class UpdateSalePriceCommandValidator : AbstractValidator<UpdateSalePriceCommand>
{
    public UpdateSalePriceCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty();
        RuleFor(p => p.SalePrice).NotNull();
    }
}
