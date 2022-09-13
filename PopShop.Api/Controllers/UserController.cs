using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PopShop.Api.DataAccess;

namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : Controller
{
    private readonly DataContext _dataContext;
    public UserController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public Models.User[] GetUsers()
    {
        return _dataContext.Users.ToArray();
    }
}
