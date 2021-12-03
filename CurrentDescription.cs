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

        /// <summary>
        /// Gets a description of the weather of a given city.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="id"> The city id. More information in More information in http://bulk.openweathermap.org/sample/ </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns>
        /// A dictionary where ["Title"] is the main title of the weather in english,
        /// and where ["Description"] is a description of the weather in the language specified.
        /// </returns>
        public static Dictionary<string, string> GetWithCityId(long id, string apiKey, string language = "en")
        {
            string file = CurrentWeather.GetWithCityId(id, apiKey, "json", "standard", language);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return new Dictionary<string, string>
            {
                ["Title"] = json.weather.First.main,
                ["Description"] = json.weather.First.description
            };
        }

        /// <summary>
        /// Gets a description of the weather of a given city asynchronously.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="id"> The city id. More information in More information in http://bulk.openweathermap.org/sample/ </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns>
        /// A dictionary where ["Title"] is the main title of the weather in english,
        /// and where ["Description"] is a description of the weather in the language specified.
        /// </returns>
        public static async Task<Dictionary<string, string>> GetWithCityIdAsync(long id, string apiKey, string language = "en")
        {
            string file = await CurrentWeather.GetWithCityIdAsync(id, apiKey, "json", "standard", language);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return new Dictionary<string, string>
            {
                ["Title"] = json.weather.First.main,
                ["Description"] = json.weather.First.description
            };
        }

        /// <summary>
        /// Gets a description of the weather of a given location.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns>
        /// A dictionary where ["Title"] is the main title of the weather in english,
        /// and where ["Description"] is a description of the weather in the language specified.
        /// </returns>
        public static Dictionary<string, string> GetWithGeoCoordinates(double latitude, double longitude, string apiKey, string language = "en")
        {
            string file = CurrentWeather.GetWithGeoCoordinates(latitude, longitude, apiKey, "json", "standard", language);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return new Dictionary<string, string>
            {
                ["Title"] = json.weather.First.main,
                ["Description"] = json.weather.First.description
            };
        }

        /// <summary>
        /// Gets a description of the weather of a given location asynchronously.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns>
        /// A dictionary where ["Title"] is the main title of the weather in english,
        /// and where ["Description"] is a description of the weather in the language specified.
        /// </returns>
        public static async Task<Dictionary<string, string>> GetWithGeoCoordinatesAsync(double latitude, double longitude, string apiKey, string language = "en")
        {
            string file = await CurrentWeather.GetWithGeoCoordinatesAsync(latitude, longitude, apiKey, "json", "standard", language);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return new Dictionary<string, string>
            {
                ["Title"] = json.weather.First.main,
                ["Description"] = json.weather.First.description
            };
        }

        /// <summary>
        /// Gets a description of the weather of a given location.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zipCode"> The ZIP Code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns>
        /// A dictionary where ["Title"] is the main title of the weather in english,
        /// and where ["Description"] is a description of the weather in the language specified.
        /// </returns>
        public static Dictionary<string, string> GeWithZIPCode(string zipCode, string apiKey, string language = "en")
        {
            string file = CurrentWeather.GetWithZIPCode(zipCode, apiKey, "json", "standard", language);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return new Dictionary<string, string>
            {
                ["Title"] = json.weather.First.main,
                ["Description"] = json.weather.First.description
            };
        }

        /// <summary>
        /// Gets a description of the weather of a given location asynchronously.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zipCode"> The ZIP Code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns>
        /// A dictionary where ["Title"] is the main title of the weather in english,
        /// and where ["Description"] is a description of the weather in the language specified.
        /// </returns>
        public static async Task<Dictionary<string, string>> GetWithZIPCodeAsync(string zipCode, string apiKey, string language = "en")
        {
            string file = await CurrentWeather.GetWithZIPCodeAsync(zipCode, apiKey, "json", "standard", language);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return new Dictionary<string, string>
            {
                ["Title"] = json.weather.First.main,
                ["Description"] = json.weather.First.description
            };
        }
    }
}