var builder = WebApplication.CreateBuilder(args);

// CORS Origin setup
var MyCorsOrigins = "_myCorsOrigins";

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyCorsOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:5173/")
            .AllowAnyHeader() // Allow all headers
            .AllowAnyMethod(); // Allow all HTTP methods (GET, POST, PUT, DELETE, etc.)
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();   // Enables Swagger UI in development
}

app.UseHttpsRedirection();

// Use the CORS policy
app.UseCors(MyCorsOrigins); // This must be placed after UseRouting(), and before MapGet/MapPost etc.

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");


// --- NEW ENDPOINTS STARTS HERE ---
app.MapGet("/greet/{name}", (string name) => $"Hello, {name}!");


// --- NEW ENDPOINTS END HERE ---

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
