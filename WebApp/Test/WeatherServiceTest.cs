using NUnit.Framework;
using WebApp.Service;

namespace WebApp.Test;


public class WeatherServiceTest {

	private HttpClient client;
	private WeatherService service;


	[SetUp]
	public void Setup() {
		client = new HttpClient { BaseAddress = new Uri("http://api.openweathermap.org/") };
		service = new WeatherService(client);
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
