namespace Basket.API.Basket.DeleteBasket;

public record DeleteBasketCommand(string UserName) : ICommand<DeleteBasketResult>;
public record DeleteBasketResult(bool IsSuccess);

public class DeleteBasketCommandValidator : AbstractValidator<DeleteBasketCommand>
{
    public DeleteBasketCommandValidator()
    {
        RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
    }
}
public class DeleteBasketCommandHandler(IBasketRepository _repository) 
    : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
{
    public async Task<DeleteBasketResult> Handle(DeleteBasketCommand command, CancellationToken token)
    {
        // TODO: session.Delete<Product>(command.Id);
        await _repository.DeleteBasketAsync(command.UserName, token);

        return new DeleteBasketResult(true);
    }
}
