using App1.Core.Models.SearchModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;

using App1.Core.Helpers;

namespace App1.Core.ApiHelper.SearchHelper
{
    public class SearchHelper
	{
		public static async Task<List<LocationItem>> GetSuggestions(string text)
		{
			string uri = UrlBuilder(text);
            List<LocationItem> result = new List<LocationItem>();
            await Task.Run(() =>
            {
                ExecuteQueryGetSuggestions(uri,
                    (response) =>
                    {
                        IAsyncAction a = CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                        {
                            if (response != null)
                            {
                                foreach (Item item in response.items)
                                {
                                    if (item.localityType != null)
                                    {
                                        if (item.localityType == "city" || item.localityType == "county")
                                        {

                                            string[] locationNames = item.title.Split(',');
                                            string title = locationNames[0];
                                            string subtitle = "";
                                            if (locationNames.Length > 2)
                                            {
                                                subtitle = locationNames[1];
                                                for (int i = 2; i <= locationNames.Length - 1; i++)
                                                {
                                                    subtitle = subtitle + "," + locationNames[i];
                                                }
                                            }
                                            string id = item.id;
                                            LocationItem simpleItem = new LocationItem(title, subtitle, id, item.position);

                                            result.Add(simpleItem);
                                        }
                                    }
                                }
                            }

                        });
                        return true;
                    },
                    (error) =>
                    {
                        IAsyncAction a = CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                        {
                            System.Diagnostics.Debug.WriteLine(error);
                        });
                        return false;
                    });

            });
            return result;

        }

        private static async void ExecuteQueryGetSuggestions(string query, Func<Suggestions, bool> success, Func<string, bool> error)
        {
            try
            {
                success(await ApiConnector.DoQueryAsync<Suggestions>(query));
            }
            catch (Exception e)
            {
                error(e.Message);
            }
        }

        private static string UrlBuilder(string text)
		{
			string query = SearchConsts.AUTOCOMPLETE_SUGGEST_HEREapi;
			query = query.Replace("{lat}", SearchConsts.DEFAULT_COORDENATE);
			query = query.Replace("{lang}", SearchConsts.DEFAULT_COORDENATE);
			query = query.Replace("{text}", text);
			query = query.Replace("{language}", "en-US");
			query = query.Replace("{key}", SearchConsts.HERE_APIKEY);

			return query;
		}

	}
}
