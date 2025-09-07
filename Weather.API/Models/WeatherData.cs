using System.Text.Json.Serialization;

namespace Weather.API.Models;

public class WeatherData
{
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("resolvedAddress")]
    public string ResolvedAddress { get; set; } = string.Empty;

    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;

    [JsonPropertyName("timezone")]
    public string Timezone { get; set; } = string.Empty;

    [JsonPropertyName("tzoffset")]
    public float TzOffset { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("days")]
    public ICollection<WeatherDay> Days { get; set; } = new List<WeatherDay>();
}