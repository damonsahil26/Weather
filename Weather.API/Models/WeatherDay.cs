namespace Weather.API.Models;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class WeatherDay
{
    [JsonPropertyName("datetime")]
    public string DateTime { get; set; } = string.Empty;

    [JsonPropertyName("datetimeEpoch")]
    public long DateTimeEpoch { get; set; }

    [JsonPropertyName("tempmax")]
    public double TempMax { get; set; }

    [JsonPropertyName("tempmin")]
    public double TempMin { get; set; }

    [JsonPropertyName("temp")]
    public double Temp { get; set; }

    [JsonPropertyName("feelslikemax")]
    public double FeelsLikeMax { get; set; }

    [JsonPropertyName("feelslikemin")]
    public double FeelsLikeMin { get; set; }

    [JsonPropertyName("feelslike")]
    public double FeelsLike { get; set; }

    [JsonPropertyName("dew")]
    public double Dew { get; set; }

    [JsonPropertyName("humidity")]
    public double Humidity { get; set; }

    [JsonPropertyName("precip")]
    public double Precip { get; set; }

    [JsonPropertyName("precipprob")]
    public double PrecipProb { get; set; }

    [JsonPropertyName("precipcover")]
    public double PrecipCover { get; set; }

    [JsonPropertyName("preciptype")]
    public List<string>? PrecipType { get; set; }

    [JsonPropertyName("snow")]
    public double Snow { get; set; }

    [JsonPropertyName("snowdepth")]
    public double SnowDepth { get; set; }

    [JsonPropertyName("windgust")]
    public double WindGust { get; set; }

    [JsonPropertyName("windspeed")]
    public double WindSpeed { get; set; }

    [JsonPropertyName("winddir")]
    public double WindDir { get; set; }

    [JsonPropertyName("pressure")]
    public double Pressure { get; set; }

    [JsonPropertyName("cloudcover")]
    public double CloudCover { get; set; }

    [JsonPropertyName("visibility")]
    public double Visibility { get; set; }

    [JsonPropertyName("solarradiation")]
    public double SolarRadiation { get; set; }

    [JsonPropertyName("solarenergy")]
    public double SolarEnergy { get; set; }

    [JsonPropertyName("uvindex")]
    public double UvIndex { get; set; }

    [JsonPropertyName("severerisk")]
    public double SevereRisk { get; set; }

    [JsonPropertyName("sunrise")]
    public string Sunrise { get; set; } = string.Empty;

    [JsonPropertyName("sunriseEpoch")]
    public long SunriseEpoch { get; set; }

    [JsonPropertyName("sunset")]
    public string Sunset { get; set; } = string.Empty;

    [JsonPropertyName("sunsetEpoch")]
    public long SunsetEpoch { get; set; }

    [JsonPropertyName("moonphase")]
    public double MoonPhase { get; set; }

    [JsonPropertyName("conditions")]
    public string Conditions { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = string.Empty;

    [JsonPropertyName("stations")]
    public List<string>? Stations { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; } = string.Empty;

    [JsonPropertyName("hours")]
    public List<WeatherHour> Hours { get; set; } = new();
}