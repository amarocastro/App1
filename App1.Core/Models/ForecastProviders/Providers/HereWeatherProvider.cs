using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using App1.Core.Models.ForecastProviders.HereWeatherModel;


namespace App1.Core.Models.ForecastProviders.Providers
{
	public class HereWeatherProvider : ForecastProviderMask
	{
		public NowForecast observation;

		public HereWeatherProvider(string name)
		{
			this.Name = name;
		}

		public override string getCurrentTemp()
		{
			
			return Math.Truncate(this.observation.location.First<Info>().observation.First<CurrentInformation>().temperature).ToString();

		}

		public override string getDescription()
		{

			return this.observation.location.First<Info>().observation.First<CurrentInformation>().description.ToString();

		}

		public override string getFeelingTemp()
		{

			return Math.Truncate(this.observation.location.First<Info>().observation.First<CurrentInformation>().comfort).ToString();

		}

		public override string getHumidity()
		{

			return this.observation.location.First<Info>().observation.First<CurrentInformation>().humidity.ToString();

		}

		public override string getPressure()
		{

			return Math.Truncate(this.observation.location.First<Info>().observation.First<CurrentInformation>().barometerPressure).ToString();

		}

		public override string getRocio()
		{

			return Math.Truncate(this.observation.location.First<Info>().observation.First<CurrentInformation>().dewPoint).ToString();

		}

		public override string getVisibility()
		{

			return this.observation.location.First<Info>().observation.First<CurrentInformation>().distance.ToString();

		}

		public override string getWindSpeed()
		{

			return this.observation.location.First<Info>().observation.First<CurrentInformation>().windSpeed.ToString();

		}

		public override List<ForecastHourly> getHourlyForecast()
		{
			List<ForecastHourly> hourlyList = new List<ForecastHourly>();
			List<CurrentInformation> observationList = this.observation.location.First<Info>().observation;

			for (int i = 1; i < observationList.Count(); i++) 
			{
				ForecastHourly item = new ForecastHourly();
				item.temperature = observationList[i].temperature;
				item.humidity = observationList[i].humidity;
				item.windSpeed = observationList[i].windSpeed;
				item.time = observationList[i].utcTime;
				item.description = observationList[i].skyDescription;
			}

			return hourlyList;
		}
	}
}
