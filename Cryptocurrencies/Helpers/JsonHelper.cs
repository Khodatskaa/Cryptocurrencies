using Newtonsoft.Json;

namespace Cryptocurrencies.Helpers
{
    public static class JsonHelper
    {
        public static T Deserialize<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}
