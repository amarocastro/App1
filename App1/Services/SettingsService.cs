using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email.DataProvider;
using Windows.UI.Xaml.Controls;

using App1.Core.Models.ForecastProviders;
using Windows.Storage;
using App1.Helpers;
using App1.Core.Models.ForecastProviders.Providers;
using App1.ViewModels;

namespace App1.Services
{
    public class SettingsService
    {
        public static Provider Provider { get; set; } = Provider.HereWeather;

        private const string SettingsKey = "AppForecastProvider";

        public static async Task InitializeAsync()
        {
            Provider = await LoadProviderFromSettingsAsync();
        }

        public static async Task SetProviderAsync(Provider provider)
        {
            Provider = provider;
            //await SetRequestedProviderAsync();
            await SaveProviderInSettingsAsync(provider);
        }

        private static async Task SetRequestedProviderAsync()
        {
            //Actualizar el resto de vistas con el nuevo proveedor

        }

        private static async Task<Provider> LoadProviderFromSettingsAsync()
        {
            Provider providerCache = Provider.HereWeather;
            string providerName = await ApplicationData.Current.LocalSettings.ReadAsync<string>(SettingsKey);

            if (!string.IsNullOrEmpty(providerName))
            {
                Enum.TryParse(providerName, out providerCache);
            }

            return providerCache;
        }

        private static async Task SaveProviderInSettingsAsync(Provider provider)
        {
            await ApplicationData.Current.LocalSettings.SaveAsync(SettingsKey, provider.ToString());
        }
    }
}
