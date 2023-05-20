using WeatherWinForms.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;
using System.Diagnostics.Metrics;

namespace WeatherWinForms.Services
{
	public class OpenWeatherMap
	{
		private readonly string _apiKey;
		private readonly HttpClient _httpClient;
		private readonly bool _useHttps;
		private readonly string _units;

		public OpenWeatherMap(string apiKey, bool useHttps = false, string units = "metric")
		{
			_apiKey = apiKey;
			_httpClient = new HttpClient();
			_useHttps = useHttps;
			_units = units;
		}

		private Uri GenerateRequestUrl(string queryString)
		{
			string scheme = _useHttps ? "https" : "http";

			return new Uri($"{scheme}://api.openweathermap.org/data/2.5/weather?{queryString}&appid={_apiKey}&units={_units}");
		}


		/// <summary>
		///
		/// </summary>
		/// <returns>Returns null if the query is invalid.</returns>
		public async Task<WeatherForecast?> GetCurrentWeather(string cityName, string? stateCode = null, string? countryCode = null)
		{
			#region making a query string
			string queryString = $"q={cityName}";
			if (string.IsNullOrEmpty(stateCode))
				queryString += $",{stateCode}";
			if (string.IsNullOrEmpty(countryCode))
				queryString += $",{countryCode}";
			#endregion

			// TODO: make exception handling
			var jsonResponse = await _httpClient.GetFromJsonAsync<WeatherForecast>(GenerateRequestUrl(queryString));
			return jsonResponse;
		}

		/// <summary>
		///
		/// </summary>
		/// <returns>Returns null if the query is invalid.</returns>
		public async Task<WeatherForecast?> GetCurrentWeather(double latitude, double longitude)
		{
			#region making a query string
			string queryString = $"lat={latitude}&lon={longitude}";
			#endregion

			// TODO: make exception handling
			var jsonResponse = await _httpClient.GetFromJsonAsync<WeatherForecast>(GenerateRequestUrl(queryString));
			return jsonResponse;
		}
	}
}
