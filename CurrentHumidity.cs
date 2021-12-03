using Newtonsoft.Json;

namespace Weather.NET
{
    /// <summary>
    /// Provides the humidity percentage of a specific location.
    /// </summary>
    public static class CurrentHumidity
    {
        /// <summary>
        /// Gets the current humidity percentage in a given city.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The current humidity (%) as an integer. </returns>
        public static int GetWithCityName(string name, string apiKey)
        {
            string file = CurrentWeather.GetWithCityName(name, apiKey);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.humidity;
        }
    }
}