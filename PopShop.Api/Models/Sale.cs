using System.Text.Json;

namespace PopShop.Api.Models;

public class Sale
{
    public Guid Id { get; set; }
    public Cart Cart { get; set; }
    public string FormPayment { get; set; }
    public string Address { get; set; }
    public DateTime CreationDate { get; set; }
    public bool Active { get; set; }
    public string sla { get; set; }
}
