namespace PopShop.Api.Models;

public class Cart
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public DateTime CreationDate { get; set; }
}
