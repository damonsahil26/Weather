using System.Text.Json;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Weather.API.Models;

namespace Weather.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
        HttpClient httpClient,
        IConfiguration configuration)
    {
        _logger = logger;
        _httpClient = httpClient;
        _configuration = configuration;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get([FromQuery(Name = "city")] string city)
    {
        try
        {
            var query = new Dictionary<string, string> { { "key", _configuration["WEATHER_API_KEY"] ?? string.Empty } };
            var url = QueryHelpers.AddQueryString($"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}", query);
            var result = await _httpClient.GetAsync(url);
            if (!result.IsSuccessStatusCode)
            {
                return StatusCode(500);
            }
            
            var weatherForecast = await JsonSerializer.DeserializeAsync<WeatherData>(await result.Content.ReadAsStreamAsync());
            return Ok(weatherForecast);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}