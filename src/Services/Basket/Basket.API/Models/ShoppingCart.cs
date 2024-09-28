namespace Basket.API.Models;
public class ShoppingCart
{
    public String UserName { get; set; } = default!;
    public List<ShopingCartItem> Items { get; set; } = new();
    public decimal TotalPrice => Items.Sum(x => x.Price * x.Quantity);
    public ShoppingCart(string userName)
    {
        UserName = userName;
    }

    // Reqruired for mapping
    public ShoppingCart()
    {
        
    }
}

