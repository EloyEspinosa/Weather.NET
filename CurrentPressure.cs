using Newtonsoft.Json;

namespace Weather.NET
{
    /// <summary>
    /// Provides the atmospheric pressure of a specific location.
    /// </summary>
    public static class CurrentPressure
    {
        // TODO: Change return statement.
        /// <summary>
        /// Gets the current atmospheric pressure in a given city.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The current atmospheric pressure (hPa) as an integer. </returns>
        public static int GetWithCityName(string name, string apiKey)
        {
            string file = CurrentWeather.GetWithCityName(name, apiKey);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.pressure;
        }

        /// <summary>
        /// Gets the current atmospheric pressure in a given city asynchronously.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The current atmospheric pressure (hPa) as an integer. </returns>
        public static async Task<int> GetWithCityNameAsync(string name, string apiKey)
        {
            string file = await CurrentWeather.GetWithCityNameAsync(name, apiKey);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.pressure;
        }

        /// <summary>
        /// Gets the current atmospheric pressure in a given city.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="id"> The city id. More information in http://bulk.openweathermap.org/sample/ </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The current atmospheric pressure (hPa) as an integer. </returns>
        public static int GetWithCityId(long id, string apiKey)
        {
            string file = CurrentWeather.GetWithCityId(id, apiKey);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.pressure;
        }

        /// <summary>
        /// Gets the current atmospheric pressure in a given city asynchronously.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="id"> The city id. More information in http://bulk.openweathermap.org/sample/ </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The current atmospheric pressure (hPa) as an integer. </returns>
        public static async Task<int> GetWithCityIdAsync(long id, string apiKey)
        {
            string file = await CurrentWeather.GetWithCityIdAsync(id, apiKey);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.pressure;
        }

        /// <summary>
        /// Gets the current atmospheric pressure in a given location.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The current atmospheric pressure (hPa) as an integer. </returns>
        public static int GetWithGeoCoordinates(double latitude, double longitude, string apiKey)
        {
            string file = CurrentWeather.GetWithGeoCoordinates(latitude, longitude, apiKey);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.pressure;
        }

        /// <summary>
        /// Gets the current atmospheric pressure in a given location asynchronously.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The current atmospheric pressure (hPa) as an integer. </returns>
        public static async Task<int> GetWithGeoCoordinatesAsync(double latitude, double longitude, string apiKey)
        {
            string file = await CurrentWeather.GetWithGeoCoordinatesAsync(latitude, longitude, apiKey);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.pressure;
        }

        /// <summary>
        /// Gets the current atmospheric pressure in a given location.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zipCode"> The ZIP code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The current atmospheric pressure (hPa) as an integer. </returns>
        public static int GetWithZIPCode(string zipCode, string apiKey)
        {
            string file = CurrentWeather.GetWithZIPCode(zipCode, apiKey);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.pressure;
        }

        /// <summary>
        /// Gets the current atmospheric pressure in a given location asynchronously.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zipCode"> The ZIP code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The current atmospheric pressure (hPa) as an integer. </returns>
        public static async Task<int> GetWithZIPCodeAsync(string zipCode, string apiKey)
        {
            string file = await CurrentWeather.GetWithZIPCodeAsync(zipCode, apiKey);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.pressure;
        }
    }
}