namespace PopShop.Api.Models;

public class Store
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PhotoUrl { get; set; }
    public User User { get; set; }
}
