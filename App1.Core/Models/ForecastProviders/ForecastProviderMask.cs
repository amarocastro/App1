using System;
using System.Collections.Generic;
using System.Text;

using App1.Core.Models.ForecastProviders;

namespace App1.Core.Models.ForecastProviders
{
	public abstract class ForecastProviderMask : ForecastProviderInterface
	{
		private string _name;

		public string Name
		{
			get
			{
				return _name;
			}
			set { _name = value; }
		}

		public abstract string getCurrentTemp();
		public abstract string getDescription();
		public abstract string getFeelingTemp();
		public abstract string getHumidity();
		public abstract string getPressure();
		public abstract string getRocio();
		public abstract string getVisibility();
		public abstract string getWindSpeed();
		public abstract List<ForecastHourly> getHourlyForecast();
	}

}
