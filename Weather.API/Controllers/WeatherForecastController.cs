using System.Text.Json;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using StackExchange.Redis;
using Weather.API.Models;

namespace Weather.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    private readonly IDatabase _redisDatabase;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
        HttpClient httpClient,
        IConfiguration configuration,
        IConnectionMultiplexer redisConnectionMultiplexer)
    {
        _logger = logger;
        _httpClient = httpClient;
        _configuration = configuration;
        _redisDatabase = redisConnectionMultiplexer.GetDatabase();
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get([FromQuery(Name = "city")] string city)
    {
        try
        {
            WeatherData? weatherData = new WeatherData();
            if (_redisDatabase.KeyExists($"weather:{city}"))
            {
                var cachedValue = await _redisDatabase.StringGetAsync($"weather:{city}");
                if (cachedValue.HasValue)
                {
                    weatherData = JsonSerializer.Deserialize<WeatherData>(cachedValue);
                }
            }
            else
            {
                var query = new Dictionary<string, string>
                    { { "key", _configuration["WEATHER_API_KEY"] ?? string.Empty } };
                var url = QueryHelpers.AddQueryString(
                    $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{city}",
                    query);
                var result = await _httpClient.GetAsync(url);
               
                if (!result.IsSuccessStatusCode)
                {
                    return StatusCode(500);
                }
                var data = await result.Content.ReadAsStringAsync();
                
                await _redisDatabase.StringSetAsync($"weather:{city}", data,
                    TimeSpan.FromDays(1));
                
                weatherData = JsonSerializer.Deserialize<WeatherData>(data, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }

            return Ok(weatherData);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }
}