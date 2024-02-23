using System.Net.Http.Json;
using WebApp.Model;

namespace WebApp.Service; 
public class WeatherService(HttpClient client, IConfiguration configuration) {

	public async Task<WeatherForecast?> GetWeather(string lat, string lon) {
		var response = await client.GetAsync($"/data/2.5/forecast/?lat={lat}&lon={lon}&appid={configuration["API_TOKEN"]}");
		if (!response.IsSuccessStatusCode)
			return null;
	

		return await response.Content.ReadFromJsonAsync<WeatherForecast>();
	}
	
	
}
