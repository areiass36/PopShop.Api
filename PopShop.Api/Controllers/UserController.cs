using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : Controller
{
    public UserController(){}

    [HttpGet]
    public string GetUsers()
    {
	return "Users";	
    }
}
