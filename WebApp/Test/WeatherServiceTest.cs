using NUnit.Framework;
using WebApp.Service;
using Microsoft.Extensions.Configuration;

namespace WebApp.Test;


public class WeatherServiceTest {

	private HttpClient client;
	private WeatherService service;
	private IConfiguration _configuration;

	[SetUp]
	public void Setup() {
		_configuration = new ConfigurationBuilder()
			.AddJsonFile("appsettings.test.json")
			.Build();
		client = new HttpClient { BaseAddress = new Uri("http://api.openweathermap.org/") };
		service = new WeatherService(client, _configuration);
	}

	[TearDown]
	public void TearDown() {
		client.Dispose();
	}

	[Test]
	public async Task GetWeatherTest() {
		var result = await service.GetWeather("35", "139");
		Assert.That(result, Is.Not.Null);
		Assert.That(result!.city.name, Is.EqualTo("Shuzenji"));
	}
}
