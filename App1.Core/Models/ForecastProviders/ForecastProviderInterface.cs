using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Core.Models.ForecastProviders
{
	public interface ForecastProviderInterface
	{
		string getCurrentTemp();
		string getDescription();
		string getFeelingTemp();
		string getWindSpeed();
		string getVisibility();
		string getPressure();
		string getHumidity();
		string getRocio();
		List<ForecastHourly> getHourlyForecast();
	}
}
