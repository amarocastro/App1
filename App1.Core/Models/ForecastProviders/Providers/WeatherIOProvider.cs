using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Core.Models.ForecastProviders.Providers
{
	public class WeatherIOProvider:ForecastProviderMask
	{
		public WeatherIOProvider(string name)
		{
			this.Name = name;
		}

		public override string getCurrentTemp()
		{
			throw new NotImplementedException();
		}

		public override string getDescription()
		{
			throw new NotImplementedException();
		}

		public override string getFeelingTemp()
		{
			throw new NotImplementedException();
		}

		public override string getHumidity()
		{
			throw new NotImplementedException();
		}

		public override string getPressure()
		{
			throw new NotImplementedException();
		}

		public override string getRocio()
		{
			throw new NotImplementedException();
		}

		public override string getVisibility()
		{
			throw new NotImplementedException();
		}

		public override string getWindSpeed()
		{
			throw new NotImplementedException();
		}
	}
}
