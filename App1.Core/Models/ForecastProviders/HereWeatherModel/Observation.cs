using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Core.Models.ForecastProviders.HereWeatherModel
{
	public class NowForecast
	{
		public List<Info> location { get; set; }
		public int timezone { get; set; }
	}
	public class Info
	{
		public List<CurrentInformation> observation { get; set; }
	}
	public class CurrentInformation
	{
		public string description { get; set; }
		public int skyInfo { get; set; }
		public string skyDescription { get; set; }
		public decimal temperature { get; set; }
		public string temperatureDesc { get; set; }
		public decimal comfort { get; set; }
		public decimal highTemperature { get; set; }
		public decimal lowTemperature { get; set; }
		public int humidity { get; set; }
		public decimal dewPoint { get; set; }
		public decimal windSpeed { get; set; }
		public decimal windDirection { get; set; }
		public string windDesc { get; set; }
		public string windDescShort { get; set; }
		public decimal barometerPressure { get; set; }
		public string iconName { get; set; }
		public decimal distance { get; set; }

		public DateTime utcTime { get; set; }

	}
}
