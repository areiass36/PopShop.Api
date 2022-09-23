namespace PopShop.Api.Models;

public class Phone
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;

}