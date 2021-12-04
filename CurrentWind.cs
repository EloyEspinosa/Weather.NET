using Newtonsoft.Json;

namespace Weather.NET
{
    /// <summary>
    /// Provides a description of the wind of a specific location.
    /// </summary>
    public static class CurrentWind
    {
        /// <summary>
        /// Gets the description of the wind of a given city.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <returns> 
        /// A tuple that contains:
        /// - double: Wind speed, depends on measurement value.
        /// - int: Wind direction, in degrees.
        /// </returns>
        public static (double, int) GetWithCityName(string name, string apiKey, string measurement = "standard")
        {
            string file = CurrentWeather.GetWithCityName(name, apiKey, "json", measurement);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return (json.wind.speed, json.wind.deg);
        }
    }
}