using Microsoft.AspNetCore.Mvc;
using PopShop.Api.DataContract;

namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
	[HttpGet]
	public async Task<PageResponse<Product>> GetClient([FromQuery] PageRequest<ProductFilter> request)
	{
		return new PageResponse<Product>()
		{
			CurrentPage = 1,
			HasNextPage = false,
			MaxPage = 1,
			Result = new []
			{
				new Product()
				{
					Id = Guid.NewGuid(),
					Name = "Produto A"
				}
			}
		};
	}
}
