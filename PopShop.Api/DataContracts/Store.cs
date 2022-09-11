namespace PopShop.Api.DataContract;

public class Store 
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public string PhotoUrl { get; set; } = string.Empty;
}
