using App1.Core.Models.ForecastProviders;
using App1.Core.Models.SearchModel;
using App1.Helpers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    public class ForecastViewModel : Observable
    {
        private LocationItem _locationItem;
        private DateTime _updateTime;
        private int _actualTemperature;
        private int _actualFeelingTemperature;
        private int _actualMaxTemperature;
        private int _actualDewPoint;
        private int _actualWindSpeed;
        private int _actualWindDirection;
        private int _actualPressure;
        private int _actualVisibility;
        private List<ForecastHourly> _nextHoursInfo;

        public async Task InitializeAsync(LocationItem locationItem)
        {

        }
    }
}
