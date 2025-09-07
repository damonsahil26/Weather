using System.Threading.RateLimiting;
using Microsoft.AspNetCore.RateLimiting;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
{
    var connectionMultiplexer = ConnectionMultiplexer
        .Connect(builder.Configuration["redisConnectionString"] ?? "localhost");
    
    return connectionMultiplexer;
});

builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed_window", config =>
    {
        config.Window = TimeSpan.FromSeconds(10);
        config.PermitLimit = 5;
        config.QueueLimit = 0;
        config.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseSwagger();

app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers()
    .RequireRateLimiting("fixed_window");

app.Run();