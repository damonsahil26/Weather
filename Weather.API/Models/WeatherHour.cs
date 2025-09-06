using System.Text.Json.Serialization;

namespace Weather.API.Models;
public class WeatherHour
{
    [JsonPropertyName("datetime")]
    public string DateTime { get; set; } = string.Empty;

    [JsonPropertyName("datetimeEpoch")]
    public long DateTimeEpoch { get; set; }

    [JsonPropertyName("temp")]
    public double Temp { get; set; }

    [JsonPropertyName("feelslike")]
    public double FeelsLike { get; set; }

    [JsonPropertyName("humidity")]
    public double Humidity { get; set; }

    [JsonPropertyName("dew")]
    public double Dew { get; set; }

    [JsonPropertyName("precip")]
    public double Precip { get; set; }

    [JsonPropertyName("precipprob")]
    public double PrecipProb { get; set; }

    [JsonPropertyName("snow")]
    public double Snow { get; set; }

    [JsonPropertyName("snowdepth")]
    public double SnowDepth { get; set; }

    [JsonPropertyName("preciptype")]
    public List<string>? PrecipType { get; set; }

    [JsonPropertyName("windgust")]
    public double WindGust { get; set; }

    [JsonPropertyName("windspeed")]
    public double WindSpeed { get; set; }

    [JsonPropertyName("winddir")]
    public double WindDir { get; set; }

    [JsonPropertyName("pressure")]
    public double Pressure { get; set; }

    [JsonPropertyName("visibility")]
    public double Visibility { get; set; }

    [JsonPropertyName("cloudcover")]
    public double CloudCover { get; set; }

    [JsonPropertyName("solarradiation")]
    public double SolarRadiation { get; set; }

    [JsonPropertyName("solarenergy")]
    public double SolarEnergy { get; set; }

    [JsonPropertyName("uvindex")]
    public double UvIndex { get; set; }

    [JsonPropertyName("severerisk")]
    public double SevereRisk { get; set; }

    [JsonPropertyName("conditions")]
    public string Conditions { get; set; } = string.Empty;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = string.Empty;

    [JsonPropertyName("stations")]
    public List<string>? Stations { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; } = string.Empty;
}
