namespace PopShop.Api.Models;

public class Store
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PhotoUrl { get; set; } = string.Empty;
    public User User { get; set; } = new();
    public IEnumerable<StoreLike> Likes { get; set; } = Enumerable.Empty<StoreLike>();
}
public class StoreLike
{
    public Guid StoreId { get; set; }
    public Guid UserId { get; set; }
}
