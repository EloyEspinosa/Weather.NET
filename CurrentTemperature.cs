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

        /// <summary>
        /// Gets the current temperature in a given city asynchronously.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <returns> The current temperature as a double. </returns>
        public static async Task<double> GetWithCityNameAsync(string name, string apiKey, string measurement = "standard")
        {
            string file = await CurrentWeather.GetWithCityNameAsync(name, apiKey, "json", measurement, "en");
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.temp;
        }

        /// <summary>
        /// Gets the current temperature in a given city.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="id"> The city id. More information in http://bulk.openweathermap.org/sample/ </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <returns> The current temperature as a double. </returns>
        public static double GetWithCityId(long id, string apiKey, string measurement = "standard")
        {
            string file = CurrentWeather.GetWithCityId(id, apiKey, "json", measurement, "en");
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.temp;
        }

        /// <summary>
        /// Gets the current temperature in a given city asynchronously.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="id"> The city id. More information in http://bulk.openweathermap.org/sample/ </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <returns> The current temperature as a double. </returns>
        public static async Task<double> GetWithCityIdAsync(long id, string apiKey, string measurement = "standard")
        {
            string file = await CurrentWeather.GetWithCityIdAsync(id, apiKey, "json", measurement, "en");
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.temp;
        }

        /// <summary>
        /// Gets the current temperature in a given location.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <returns> The current temperature as a double. </returns>
        public static double GetWithGeoCoordinates(double latitude, double longitude, string apiKey, string measurement = "standard")
        {
            string file = CurrentWeather.GetWithGeoCoordinates(latitude, longitude, apiKey, "json", measurement, "en");
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.temp;
        }

        /// <summary>
        /// Gets the current temperature in a given location asynchronously.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <returns> The current temperature as a double. </returns>
        public static async Task<double> GetWithGeoCoordinatesAsync(double latitude, double longitude, string apiKey, string measurement = "standard")
        {
            string file = await CurrentWeather.GetWithGeoCoordinatesAsync(latitude, longitude, apiKey, "json", measurement, "en");
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.temp;
        }

        /// <summary>
        /// Gets the current temperature in a given location.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zip"> The ZIP code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <returns> The current temperature as a double. </returns>
        public static double GetWithZIPCode(string zipCode, string apiKey, string measurement = "standard")
        {
            string file = CurrentWeather.GetWithZIPCode(zipCode, apiKey, "json", measurement, "en");
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.temp;
        }

        /// <summary>
        /// Gets the current temperature in a given location asynchronously.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zip"> The ZIP code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <returns> The current temperature as a double. </returns>
        public static async Task<double> GetWithZIPCodeAsync(string zipCode, string apiKey, string measurement = "standard")
        {
            string file = await CurrentWeather.GetWithZIPCodeAsync(zipCode, apiKey, "json", measurement, "en");
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.temp;
        }
    }
}