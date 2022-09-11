namespace PopShop.Api.Models;

public class Address
{
	public string PostalCode { get; set; } = string.Empty;
	public string PublicArea { get; set; } = string.Empty;
	public string Complement { get; set; } = string.Empty;
	public string Distric { get; set; } = string.Empty;
	public string City { get; set; } = string.Empty;
	public string State { get; set; } = string.Empty;
}
