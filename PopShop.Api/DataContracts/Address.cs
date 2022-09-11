using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PopShop.Api.DataContract;

public class Address
{
    [JsonProperty(PropertyName = "cep")]
    public string PostalCode { get; set; } = string.Empty;
    [JsonProperty(PropertyName = "logradouro")]
    public string PublicArea { get; set; } = string.Empty;
    [JsonProperty(PropertyName = "complemento")]
    public string Complement { get; set; } = string.Empty;
    [JsonProperty(PropertyName = "bairro")]
    public string Distric { get; set; } = string.Empty;
    [JsonProperty(PropertyName = "localidade")]
    public string City { get; set; } = string.Empty;
    [JsonProperty(PropertyName = "uf")]
    public string State { get; set; } = string.Empty;

}
