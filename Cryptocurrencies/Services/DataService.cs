using System.Collections.Generic;
using System.Threading.Tasks;
using Cryptocurrencies.Models;
using Cryptocurrencies.Services;

namespace Cryptocurrencies.Services
{
    public class DataService
    {
        public async Task<List<Cryptocurrency>> GetTopCryptocurrenciesAsync()
        {
            return await ApiService.GetTopCryptocurrenciesAsync();
        }

        public async Task<Cryptocurrency> GetCryptocurrencyDetailsAsync(string id)
        {
            return await ApiService.GetCryptocurrencyDetailsAsync(id);
        }

        public async Task<List<Market>> GetMarketsForCryptocurrencyAsync(string id)
        {
            return await ApiService.GetMarketsForCryptocurrencyAsync(id);
        }
    }
}
