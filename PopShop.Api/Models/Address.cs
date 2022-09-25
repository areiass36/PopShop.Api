namespace PopShop.Api.Models;

public class Address
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string PostalCode { get; set; } = string.Empty;
    public string PublicArea { get; set; } = string.Empty;
    public string Complement { get; set; } = string.Empty;
    public string Distric { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
}
