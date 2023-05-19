using WeatherWinForms.Models;
using WeatherWinForms.Services;

namespace WeatherWinForms.Forms
{
	public partial class OpenWeatherMapForm : Form
	{
		readonly string _apiKey;
		bool _hasHttps;

		public OpenWeatherMapForm()
		{
			InitializeComponent();

			_apiKey = "ee257dbd0ed86a0af037f66b8325c6f5";
			_hasHttps = false;
			hasHttpsCheckBox1.Checked = _hasHttps;
			hasHttpsCheckBox2.Checked = _hasHttps;

			cityNameTextBox.Text = "London";
		}

		private void hasHttpsCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			_hasHttps = hasHttpsCheckBox1.Checked;
			hasHttpsCheckBox2.Checked = _hasHttps;
		}

		private void hasHttpsCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			_hasHttps = hasHttpsCheckBox2.Checked;
			hasHttpsCheckBox1.Checked = _hasHttps;
		}

		private async void directButton_Click(object sender, EventArgs e)
		{
			#region checking for a fool
			if (string.IsNullOrEmpty(cityNameTextBox.Text))
			{
				MessageBox.Show("You didn't specify the city", "City name empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			var openWeather = new OpenWeatherMap(_apiKey, _hasHttps);
			WeatherForecast? weather = await openWeather.GetCurrentWeather(cityNameTextBox.Text, stateCodeTextBox.Text, countryCodeTextBox.Text);
			WeatherOutput(weather);
		}

		private async void reverseButton_Click(object sender, EventArgs e)
		{
			#region checking for a fool
			if (string.IsNullOrEmpty(latitudeMaskedTextBox.Text) && string.IsNullOrEmpty(longitudeMaskedTextBox.Text))
			{
				MessageBox.Show("You didn't specify the latitude or longitude", "Latitude or longitude empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!double.TryParse(latitudeMaskedTextBox.Text, out double latitude) & !double.TryParse(longitudeMaskedTextBox.Text, out double longitude))
			{
				MessageBox.Show("It is not possible to convert latitude or longitude to a double type", "Conversion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			var openWeather = new OpenWeatherMap(_apiKey, _hasHttps);
			WeatherForecast? weather = await openWeather.GetCurrentWeather(latitude, longitude);
			WeatherOutput(weather);
		}

		private void WeatherOutput(WeatherForecast? weather) 
		{
			if (weather != null)
			{
				weatherListBox.Items.Add($"City: {weather.Name}");
				weatherListBox.Items.Add($"Temperature: {weather.Main.Temp}");
				weatherListBox.Items.Add($"Wind Speed: {weather.Wind.Speed}");
				weatherListBox.Items.Add($"Description: {weather.Weather[0].Description}");
				weatherListBox.Items.Add($"-----------");
			}
			else
			{
				MessageBox.Show("Something went wrong", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
	}
}
