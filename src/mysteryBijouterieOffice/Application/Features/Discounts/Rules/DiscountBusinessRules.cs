using Application.Features.Discounts.Constants;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Discounts.Rules;

public class DiscountBusinessRules : BaseBusinessRules
{
    public Task DiscountShouldExistWhenSelected(Discount? discount)
    {
        if (discount is null)
            throw new NotFoundException(DiscountsMessages.DiscountNotExists);
        return Task.CompletedTask;
    }
}
