using System.Text.Json.Serialization;

namespace Weather.API.Models;

public class WeatherData
{
    [JsonPropertyName("latitude")]
    public double Latitude { get; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; }

    [JsonPropertyName("resolvedAddress")]
    public string ResolvedAddress { get; } = string.Empty;

    [JsonPropertyName("address")]
    public string Address { get; } = string.Empty;

    [JsonPropertyName("timezone")]
    public string Timezone { get; } = string.Empty;

    [JsonPropertyName("tzoffset")]
    public float TzOffset { get; }

    [JsonPropertyName("description")]
    public string Description { get; } = string.Empty;

    [JsonPropertyName("days")]
    public ICollection<WeatherDay> Days { get; } = new List<WeatherDay>();
}