namespace PopShop.Api.Models;

public class Review
{
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Grade { get; set; }
    public DateTime CreationDate { get; set; }
}