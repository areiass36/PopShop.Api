namespace PopShop.Api.Models;

public class User
{
	public long Id { get; set; }
	public string Name { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public string Password { get; set; }
	public int Role { get; set; }
	public string PhotoUrl { get; set; }
	public DateTime CreationDate { get; set; }
	public bool Active { get; set; }
}
