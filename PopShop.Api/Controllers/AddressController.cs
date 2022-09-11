using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PopShop.Api.Configurations;
namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : Controller
{
    private IHttpClientFactory _httpClientFactory;
    public AddressController(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

    [HttpGet("{postalcode}")]
    public async Task<DataContract.Address> GetAddress([FromRoute] string postalcode)
    {
        var httpClient = _httpClientFactory.CreateClient(ApiBaseUrl.VIA_CEP);
        var httpResponse = string.Empty;
	DateTime time = DateTime.Now;	
	
        try
        {
            httpResponse = await httpClient.GetStringAsync($"{postalcode}/json/");
        }
        catch (HttpRequestException)
        {
            return new DataContract.Address();
        }
        return JsonConvert.DeserializeObject<DataContract.Address>(httpResponse) ?? new DataContract.Address();
    }
}
