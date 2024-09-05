using System.Net.Http;
using System.Threading.Tasks;

namespace Cryptocurrencies.Helpers
{
    public static class ApiHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
