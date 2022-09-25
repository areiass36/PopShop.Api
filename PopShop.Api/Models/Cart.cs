using System.Security;

namespace PopShop.Api.Models;

public class Cart
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreationDate { get; set; }
    public IEnumerable<CartProduct> Products { get; set; } = Enumerable.Empty<CartProduct>();
}

public class CartProduct
{
    public Guid CartId { get; set; }
    public Guid ProductId { get; set; }
    public Guid VariationId { get; set; }
    public int Quantity { get; set; }
}
