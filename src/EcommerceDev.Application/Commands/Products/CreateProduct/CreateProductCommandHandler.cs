public class CreateProductCommandHandler : IHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _productRepository;
    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<Guid> HandleAsync(CreateProductCommand request)
    {
        var product = new Product(
            request.Title,
            request.Description,
            request.Price,
            request.Brand,
            request.Quantity,
            request.IdCategory
        );
        await _productRepository.AddAsync(product);
        return product.Id;
    }
}