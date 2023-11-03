using Application.Features.Categories.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Categories.Rules;

public class CategoryBusinessRules : BaseBusinessRules
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryBusinessRules(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public Task CategoryShouldExistWhenSelected(Category? category)
    {
        if (category is null)
            throw new NotFoundException(CategoriesMessages.CategoryNotExists);
        return Task.CompletedTask;
    }

    public async Task CategoryNameCanNotBeDuplicatedWhenInserted(string name)
    {
        bool doesExists = await _categoryRepository.AnyAsync(c => c.Name == name, enableTracking: false);
        if (doesExists)
            throw new BusinessException(CategoriesMessages.CategoryNameAlreadyExists);
    }

    public async Task CategoryNameCanNotBeDuplicatedWhenUpdated(int id, string name)
    {
        bool doesExists = await _categoryRepository.AnyAsync(c => c.Id != id && c.Name == name, enableTracking: false);
        if (doesExists)
            throw new BusinessException(CategoriesMessages.CategoryNameAlreadyExists);
    }
}
