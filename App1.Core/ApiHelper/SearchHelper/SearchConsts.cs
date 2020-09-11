using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Core.ApiHelper.SearchHelper
{
	public static class SearchConsts
	{
		public const string HERE_APIKEY = "RCbQ1q62PUeNAVkOD3VVsilBDMHmP4zcXkl94oLRU_s";
		public static string AUTOCOMPLETE_SUGGEST_HEREapi = "https://autosuggest.search.hereapi.com/v1/autosuggest?at={lat},{lang}&q={text}&lang={language}&limit=5&apiKey={key}";
		public const string DEFAULT_COORDENATE = "0";
	}
}
