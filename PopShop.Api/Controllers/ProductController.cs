using Microsoft.AspNetCore.Mvc;
using PopShop.Api.DataContract;

namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
	[HttpGet]
	public async Task<PageResult<Product>> GetClient([FromQuery] PageResult<ProductFilter>)
	{
		return "Hello World";
	}
}
