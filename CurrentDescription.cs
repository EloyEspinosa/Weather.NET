using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Weather.NET
{
    /// <summary>
    /// Provides the weather description of a specific location.
    /// </summary>
    public static class CurrentDescription
    {
        /// <summary>
        /// Gets a description of the weather of a given city.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns>
        /// A dictionary where ["Title"] is the main title of the weather in english,
        /// and where ["Description"] is a description of the weather in the language specified.
        /// </returns>
        public static Dictionary<string, string> GetWithCityName(string name, string apiKey, string language = "en")
        {
            string file = CurrentWeather.GetWithCityName(name, apiKey, "json", "standard", language);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return new Dictionary<string, string>
            {
                ["Title"] = json.weather.First.main,
                ["Description"] = json.weather.First.description
            };
        }

        /// <summary>
        /// Gets a description of the weather of a given city asynchronously.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns>
        /// A dictionary where ["Title"] is the main title of the weather in english,
        /// and where ["Description"] is a description of the weather in the language specified.
        /// </returns>
        public static async Task<Dictionary<string, string>> GetWithCityNameAsync(string name, string apiKey, string language = "en")
        {
            string file = await CurrentWeather.GetWithCityNameAsync(name, apiKey, "json", "standard", language);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return new Dictionary<string, string>
            {
                ["Title"] = json.weather.First.main,
                ["Description"] = json.weather.First.description
            };
        }
    }
}