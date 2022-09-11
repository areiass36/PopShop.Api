namespace PopShop.Api.DataContract;

public class Product
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public double Price { get; set; }
	public string Description { get; set; } = string.Empty;
	public IEnumerable<string> PhotoUrls { get; set; } = Enumerable.Empty<string>();
	public Store? Store { get; set; }
}
