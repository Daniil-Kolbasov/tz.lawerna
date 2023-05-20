namespace WeatherWinForms.Models
{
	public class WeatherForecast
	{
		public string Name { get; set; } = string.Empty;
		public Main Main { get; set; }
		public Wind Wind { get; set; }
		public Weather[] Weather { get; set; }

		public WeatherForecast()
		{
			Main = new();
			Wind = new();
			Weather = new Weather[1];
		}
	}

	public class Weather
	{
		public string Description { get; set; } = string.Empty;
	}

	public class Wind
	{
		public double Speed { get; set; }
	}

	public class Main
	{
		public double Temp { get; set; }
	}
}
