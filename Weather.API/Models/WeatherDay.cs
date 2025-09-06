namespace Weather.API.Models;

using System.Collections.Generic;
using System.Text.Json.Serialization;

public class WeatherDay
{
    [JsonPropertyName("datetime")]
    public string DateTime { get; } = string.Empty;

    [JsonPropertyName("datetimeEpoch")]
    public long DateTimeEpoch { get; }

    [JsonPropertyName("tempmax")]
    public double TempMax { get; }

    [JsonPropertyName("tempmin")]
    public double TempMin { get; }

    [JsonPropertyName("temp")]
    public double Temp { get; }

    [JsonPropertyName("feelslikemax")]
    public double FeelsLikeMax { get; }

    [JsonPropertyName("feelslikemin")]
    public double FeelsLikeMin { get; }

    [JsonPropertyName("feelslike")]
    public double FeelsLike { get; }

    [JsonPropertyName("dew")]
    public double Dew { get; }

    [JsonPropertyName("humidity")]
    public double Humidity { get; }

    [JsonPropertyName("precip")]
    public double Precip { get; }

    [JsonPropertyName("precipprob")]
    public double PrecipProb { get; }

    [JsonPropertyName("precipcover")]
    public double PrecipCover { get; }

    [JsonPropertyName("preciptype")]
    public List<string>? PrecipType { get; }

    [JsonPropertyName("snow")]
    public double Snow { get; }

    [JsonPropertyName("snowdepth")]
    public double SnowDepth { get; }

    [JsonPropertyName("windgust")]
    public double WindGust { get; }

    [JsonPropertyName("windspeed")]
    public double WindSpeed { get; }

    [JsonPropertyName("winddir")]
    public double WindDir { get; }

    [JsonPropertyName("pressure")]
    public double Pressure { get; }

    [JsonPropertyName("cloudcover")]
    public double CloudCover { get; }

    [JsonPropertyName("visibility")]
    public double Visibility { get; }

    [JsonPropertyName("solarradiation")]
    public double SolarRadiation { get; }

    [JsonPropertyName("solarenergy")]
    public double SolarEnergy { get; }

    [JsonPropertyName("uvindex")]
    public double UvIndex { get; }

    [JsonPropertyName("severerisk")]
    public double SevereRisk { get; }

    [JsonPropertyName("sunrise")]
    public string Sunrise { get; } = string.Empty;

    [JsonPropertyName("sunriseEpoch")]
    public long SunriseEpoch { get; }

    [JsonPropertyName("sunset")]
    public string Sunset { get; } = string.Empty;

    [JsonPropertyName("sunsetEpoch")]
    public long SunsetEpoch { get; }

    [JsonPropertyName("moonphase")]
    public double MoonPhase { get; }

    [JsonPropertyName("conditions")]
    public string Conditions { get; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; } = string.Empty;

    [JsonPropertyName("icon")]
    public string Icon { get; } = string.Empty;

    [JsonPropertyName("stations")]
    public List<string>? Stations { get; }

    [JsonPropertyName("source")]
    public string Source { get; } = string.Empty;

    [JsonPropertyName("hours")]
    public List<WeatherHour> Hours { get; } = new();
}