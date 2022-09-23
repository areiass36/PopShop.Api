namespace PopShop.Api.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Role Role { get; set; }
    public string PhotoUrl { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; }
    public Document Document { get; set; } = new();
    public bool Active { get; set; }
}
