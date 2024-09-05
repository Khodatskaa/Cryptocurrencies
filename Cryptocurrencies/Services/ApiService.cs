using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Cryptocurrencies.Helpers;
using Cryptocurrencies.Models;

namespace Cryptocurrencies.Services
{
    public static class ApiService
    {
        private const string BaseUrl = "https://api.coincap.io/v2/";

        public static async Task<List<Cryptocurrency>> GetTopCryptocurrenciesAsync(int limit = 10)
        {
            string url = $"{BaseUrl}assets?limit={limit}";
            string jsonString = await ApiHelper.GetAsync(url);

            var data = JsonConvert.DeserializeObject<dynamic>(jsonString);
            var cryptocurrencyList = new List<Cryptocurrency>();

            foreach (var item in data.data)
            {
                cryptocurrencyList.Add(JsonConvert.DeserializeObject<Cryptocurrency>(item.ToString()));
            }

            return cryptocurrencyList;
        }

        public static async Task<Cryptocurrency> GetCryptocurrencyDetailsAsync(string id)
        {
            string url = $"{BaseUrl}assets/{id}";
            string jsonString = await ApiHelper.GetAsync(url);

            var data = JsonConvert.DeserializeObject<dynamic>(jsonString);
            var cryptoDetails = JsonConvert.DeserializeObject<Cryptocurrency>(data.data.ToString());

            return cryptoDetails;
        }

        public static async Task<List<Market>> GetMarketsForCryptocurrencyAsync(string id)
        {
            string url = $"{BaseUrl}assets/{id}/markets";
            string jsonString = await ApiHelper.GetAsync(url);

            var data = JsonConvert.DeserializeObject<dynamic>(jsonString);
            var marketList = new List<Market>();

            foreach (var item in data.data)
            {
                marketList.Add(JsonConvert.DeserializeObject<Market>(item.ToString()));
            }

            return marketList;
        }
    }
}
