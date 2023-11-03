using Application.Features.Categories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Create;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreatedCategoryResponse>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    private readonly CategoryBusinessRules _categoryBusinessRules;

    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
        _categoryBusinessRules = categoryBusinessRules;
    }

    public async Task<CreatedCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        await _categoryBusinessRules.CategoryNameCanNotBeDuplicatedWhenInserted(request.Name);

        Category mappedCategory = _mapper.Map<Category>(request);
        Category createdCategory = await _categoryRepository.AddAsync(mappedCategory);
        CreatedCategoryResponse response = _mapper.Map<CreatedCategoryResponse>(createdCategory);
        return response;
    }
}
