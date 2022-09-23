namespace PopShop.Api.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; }
    public Store Store { get; set; } = new();
    public IEnumerable<ProductLike> Likes { get; set; } = Enumerable.Empty<ProductLike>();
    public IEnumerable<ProductPhoto> Photos { get; set; } = Enumerable.Empty<ProductPhoto>();
    public IEnumerable<ProductVariation> Variations { get; set; } = Enumerable.Empty<ProductVariation>();

    public bool Active { get; set; }
}
public class ProductLike
{
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
}

public class ProductPhoto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public string PhotoUrl { get; set; } = string.Empty;
}

public class ProductVariation
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
}
