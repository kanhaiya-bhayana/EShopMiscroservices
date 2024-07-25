using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> category, string Description, string ImageFile, decimal Price)
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // Business logic to create a product

            // create Product entity from command object
            var product = new Product
            {
                Name = command.Name,
                Category = command.category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };
            
            
            // save to database

            // return CreateProductResult result
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}


