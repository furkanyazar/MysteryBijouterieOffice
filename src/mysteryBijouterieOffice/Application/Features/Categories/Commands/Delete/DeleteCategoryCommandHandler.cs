using Application.Features.Categories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Delete;

public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, DeletedCategoryResponse>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    private readonly CategoryBusinessRules _categoryBusinessRules;

    public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
        _categoryBusinessRules = categoryBusinessRules;
    }

    public async Task<DeletedCategoryResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        Category? category = await _categoryRepository.GetAsync(p => p.Id == request.Id, cancellationToken: cancellationToken);

        await _categoryBusinessRules.CategoryShouldExistWhenSelected(category);

        Category deletedCategory = await _categoryRepository.DeleteAsync(category!);
        DeletedCategoryResponse response = _mapper.Map<DeletedCategoryResponse>(deletedCategory);
        return response;
    }
}
