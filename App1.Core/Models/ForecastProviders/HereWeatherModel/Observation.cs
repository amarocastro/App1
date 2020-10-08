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
		public string description { get; set; } //weather description
		public int skyInfo { get; set; } //sky status
		public string skyDescription { get; set; } //sky description
		public decimal temperature { get; set; } //actual temeprature
		public string temperatureDesc { get; set; } //temerature description
		public decimal comfort { get; set; } //feeling temperature
		public decimal highTemperature { get; set; } //max temperature
		public decimal lowTemperature { get; set; } //min temperature
		public int humidity { get; set; } //humidity %
		public decimal dewPoint { get; set; } //dew point
		public decimal windSpeed { get; set; } //wind speed
		public decimal windDirection { get; set; } //wind direction
		public string windDesc { get; set; } //wind description
		public string windDescShort { get; set; } //wind description
		public decimal barometerPressure { get; set; } //pressure
		public string iconName { get; set; } //icon code
		public decimal distance { get; set; } //visibility distance

		public DateTime utcTime { get; set; } //prediction time

	}
}
