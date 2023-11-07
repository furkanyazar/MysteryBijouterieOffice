using FluentValidation;

namespace Application.Features.Partners.Queries.GetById;

public class GetByIdPartnerQueryValidator : AbstractValidator<GetByIdPartnerQuery>
{
    public GetByIdPartnerQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty();
    }
}
