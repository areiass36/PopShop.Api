namespace PopShop.Api.DataContract;

public class ProductFilter
{
	public string Name { get; set; } = string.Empty;
	public Guid Category { get; set; }
	public double Price { get; set; }
}
