using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class StoreController : Controller
{
    public StoreController(){}

    [HttpGet]
    public string GetStores()
    {
	return "Store";	
    }
}
