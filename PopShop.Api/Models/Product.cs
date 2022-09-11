namespace PopShop.Api.Models;

public class Product
{
    public long Id { get; set; }
	public string Name { get; set; }
	public double Price { get; set; }
	public string Description { get; set; }
    public DateTime CreationDate { get; set;}
    public Store Store { get; set; }
	public bool Active { get; set; }
}
