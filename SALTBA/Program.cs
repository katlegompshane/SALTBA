using SALTBA.Classes;
using SALTBA.Interfaces;
using SALTBA.Models.CountryWeather;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICountryService, CountryService>();
builder.Services.AddSingleton<IHttpRequestService, HttpRequestService>();
builder.Services.AddSingleton<IDataDispay<WeatherPerCountry>, DataDisplayService>();
builder.Services.AddSingleton<IWeatherService, WeartherService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
