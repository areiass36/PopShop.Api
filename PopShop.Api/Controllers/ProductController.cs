using Microsoft.AspNetCore.Mvc;
using PopShop.Api.DataAccess;
using PopShop.Api.DataContract;

namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly DataContext _dataContext;
    public ProductController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<Models.Product[]> GetClient([FromQuery] PageRequest<ProductFilter> request)
    {
        return _dataContext.Products.ToArray();
        /*
			SELECT * FROM Produto
		*/
    }
}
