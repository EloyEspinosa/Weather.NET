using System;
using Newtonsoft.Json;

namespace Weather.NET
{
    /// <summary>
    /// Provides the temperature of a specific location.
    /// </summary>
    public static class CurrentTemperature
    {
        /// <summary>
        /// Gets the current temperature in a given city.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <returns> The current temperature as a double. </returns>
        public static double GetWithCityName(string name, string apiKey, string measurement = "standard")
        {
            string file = CurrentWeather.GetWithCityName(name, apiKey, "json", measurement, "en");
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.temp;
        }
    }
}