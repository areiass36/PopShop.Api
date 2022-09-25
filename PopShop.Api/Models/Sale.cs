namespace PopShop.Api.Models;

public class Sale
{
    public Guid Id { get; set; }
    public Cart Cart { get; set; } = new();
    public PaymentMethod PaymentMethod { get; set; }
    public Guid AddressId { get; set; }
    public DateTime CreationDate { get; set; }
    public bool Active { get; set; }
}

public enum PaymentMethod
{
    Undefined = 0
}

public class SaleStatus
{
    public Guid Id { get; set; }
    public Guid SaleId { get; set; }
    public SaleStatusValue Value { get; set; }
    public DateTime CreationDate { get; set; }
}

public enum SaleStatusValue
{
    Undefined = 0
}
