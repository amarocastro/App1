using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Core.Models.ForecastProviders
{
	public class ForecastHourly
	{
		public decimal temperature { get; set; }
		public string description { get; set; }
		public decimal humidity { get; set; }
		public decimal windSpeed { get; set; }
		public DateTime time { get; set; }
	}
}
