using Microsoft.AspNetCore.Mvc;

namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
	[HttpGet]
	public string GetClient()
	{
		return "Hello World";
	}
}
