using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SaleController : Controller
{
    public SaleController(){}

    [HttpGet]
    public string GetSales()
    {
	return "Sale";	
    }
}
