using Application.Features.Categories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Update;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, UpdatedCategoryResponse>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    private readonly CategoryBusinessRules _categoryBusinessRules;

    public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
        _categoryBusinessRules = categoryBusinessRules;
    }

    public async Task<UpdatedCategoryResponse> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        Category? category = await _categoryRepository.GetAsync(c => c.Id == request.Id, cancellationToken: cancellationToken);

        await _categoryBusinessRules.CategoryShouldExistWhenSelected(category);
        await _categoryBusinessRules.CategoryNameCanNotBeDuplicatedWhenUpdated(request.Id, request.Name);

        _mapper.Map(request, category);

        Category updatedCategory = await _categoryRepository.UpdateAsync(category!);
        UpdatedCategoryResponse response = _mapper.Map<UpdatedCategoryResponse>(updatedCategory);
        return response;
    }
}
