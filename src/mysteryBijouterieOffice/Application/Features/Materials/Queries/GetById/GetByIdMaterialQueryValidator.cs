using FluentValidation;

namespace Application.Features.Materials.Queries.GetById;

public class GetByIdMaterialQueryValidator : AbstractValidator<GetByIdMaterialQuery>
{
    public GetByIdMaterialQueryValidator()
    {
        RuleFor(m => m.Id).NotEmpty();
    }
}
