﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace App1.Core.Helpers
{
	public static class ApiConnector
	{
        public static async Task<T> DoQueryAsync<T>(string querie)
        {
            HttpClient client = new HttpClient();
            //{
            //    BaseAddress = new Uri(querie)
            //};

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Do the http response call with the query string and api key
            HttpResponseMessage response = client.GetAsync(querie).Result;
            //If the response code is 200
            if (response.IsSuccessStatusCode)
            {
                //Convert the response to string
                string resp = await response.Content.ReadAsStringAsync();
                T data = JsonConvert.DeserializeObject<T>(resp);
                return data;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            //Throw an exception as the reposne was not 200
            throw new Exception(response.ReasonPhrase);
        }
    }
}
