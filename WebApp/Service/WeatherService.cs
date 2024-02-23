using System.Net.Http.Json;
using WebApp.Model;

namespace WebApp.Service; 
public class WeatherService(HttpClient client) {

	public async Task<WeatherForecast?> GetWeather(string lat, string lon) {
		var response = await client.GetAsync($"/data/2.5/forecast/?lat={lat}&lon={lon}&appid=cdd338c1062e29f52bfabb733e15a0ab");
		if (!response.IsSuccessStatusCode)
			return null;

		return await response.Content.ReadFromJsonAsync<WeatherForecast>();
	}
	
	
}
