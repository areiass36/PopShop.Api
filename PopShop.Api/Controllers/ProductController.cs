using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public ICollection<Models.Product> GetClient([FromQuery] PageRequest<ProductFilter> request)
    {
        return _dataContext.Products.ToList();
        /*
			SELECT * FROM Produto
		*/
    }
}
