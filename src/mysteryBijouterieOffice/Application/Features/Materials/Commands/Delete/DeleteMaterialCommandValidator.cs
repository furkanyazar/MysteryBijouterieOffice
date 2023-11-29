using FluentValidation;

namespace Application.Features.Materials.Commands.Delete;

public class DeleteMaterialCommandValidator : AbstractValidator<DeleteMaterialCommand>
{
    public DeleteMaterialCommandValidator()
    {
        RuleFor(m => m.Id).NotEmpty();
    }
}
