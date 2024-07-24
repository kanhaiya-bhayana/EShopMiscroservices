namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> category, string Description, string ImageFile, decimal Price);
    public record CreateProductResult(Guid Id);
    public class CreateProductHandler
    {

    }
}
