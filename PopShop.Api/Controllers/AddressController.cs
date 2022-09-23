using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PopShop.Api.Configurations;
using PopShop.Api.DataContract;

namespace PopShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : Controller
{
    private IHttpClientFactory _httpClientFactory;
    public AddressController(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

    [HttpGet("{postalcode}")]
    public async Task<ViaCepAddress> GetAddress([FromRoute] string postalcode)
    {
        var httpClient = _httpClientFactory.CreateClient(ApiBaseUrl.VIA_CEP);
        var httpResponse = string.Empty;

        try
        {
            httpResponse = await httpClient.GetStringAsync($"{postalcode}/json/");
        }
        catch (HttpRequestException)
        {
            return new ViaCepAddress();
        }
        return JsonConvert.DeserializeObject<ViaCepAddress>(httpResponse) ?? new ViaCepAddress();
    }
}
