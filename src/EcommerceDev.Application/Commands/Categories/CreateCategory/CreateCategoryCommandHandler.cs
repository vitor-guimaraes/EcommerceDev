using System;

public class CreateCategoryCommandHandler : IHandler<CreateCategoryCommand, Guid>
{
    private readonly ICategoryRepository _categoryRepository;

    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public async Task<Guid> HandleAsync(CreateCategoryCommand request)
    {
        var category = new ProductCategory(
            request.Title,
            request.Subcategory
        );
        await _categoryRepository.AddAsync(category);
        return category.Id;
    }
}
