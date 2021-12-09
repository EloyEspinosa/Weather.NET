global using Newtonsoft.Json;
global using Weather.NET.Enums;
global using Weather.NET.Extensions;
global using System.Net;

namespace Weather.NET
{
    /// <summary>
    /// Provides the current weather of a specific location.
    /// OpenWeatherMap docs: https://openweathermap.org/current
    /// </summary>
    public static class CurrentWeather
    {
        /// <summary>
        /// Gets the current weather of a given city.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="cityName"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output. </param>
        /// <param name="language"> The language of the output. </param>
        /// <returns> The current weather. </returns>
        public static WeatherResponse New(string cityName, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
            NewAsync(cityName, apiKey, measurement, language).Result;

        /// <summary>
        /// Gets the current weather of a given city.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="cityId"> The OpenWeatherMap city ID. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output. </param>
        /// <param name="language"> The language of the output. </param>
        /// <returns> The current weather. </returns>
        public static WeatherResponse New(long cityId, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
            NewAsync(cityId, apiKey, measurement, language).Result;

        /// <summary>
        /// Gets the current weather of a given location.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output. </param>
        /// <param name="language"> The language of the output. </param>
        /// <returns> The current weather. </returns>
        public static WeatherResponse New(double latitude, double longitude, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
            NewAsync(latitude, longitude, apiKey, measurement, language).Result;

        /// <summary>
        /// Gets the current weather of a given location.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zipCode"> The ZIP code of the location. </param>
        /// <param name="countryCode"> The ISO 3166 country code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output. </param>
        /// <param name="language"> The language of the output. </param>
        /// <returns> The current weather. </returns>
        public static WeatherResponse New(long zipCode, string countryCode, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
            NewAsync(zipCode, countryCode, apiKey, measurement, language).Result;

        /// <summary>
        /// Gets the current weather of a given city asynchronously.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="cityName"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output. </param>
        /// <param name="language"> The language of the output. </param>
        /// <returns> The current weather. </returns>
        public static async Task<WeatherResponse> NewAsync(string cityName, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English)
        {
            string file = await ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units={measurement.Convert()}&lang={language.Convert()}");
            return New(JsonConvert.DeserializeObject<dynamic>(file));
        }

        /// <summary>
        /// Gets the current weather of a given city asynchronously.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="cityId"> The OpenWeatherMap city ID. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output. </param>
        /// <param name="language"> The language of the output. </param>
        /// <returns> The current weather. </returns>
        public static async Task<WeatherResponse> NewAsync(long cityId, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English)
        {
            string file = await ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?id={cityId}&appid={apiKey}&units={measurement.Convert()}&lang={language.Convert()}");
            return New(JsonConvert.DeserializeObject<dynamic>(file));
        }

        /// <summary>
        /// Gets the current weather of a given location asynchronously.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output. </param>
        /// <param name="language"> The language of the output. </param>
        /// <returns> The current weather. </returns>
        public static async Task<WeatherResponse> NewAsync(double latitude, double longitude, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English)
        {
            string file = await ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}&units={measurement.Convert()}&lang={language.Convert()}");
            return New(JsonConvert.DeserializeObject<dynamic>(file));
        }

        /// <summary>
        /// Gets the current weather of a given location asynchronously.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zipCode"> The ZIP code of the location. </param>
        /// <param name="countryCode"> The ISO 3166 country code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output. </param>
        /// <param name="language"> The language of the output. </param>
        /// <returns> The current weather. </returns>
        public static async Task<WeatherResponse> NewAsync(long zipCode, string countryCode, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English)
        {
            string file = await ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?zip={zipCode},{countryCode}&appid={apiKey}&units={measurement.Convert()}&lang={language.Convert()}");
            return New(JsonConvert.DeserializeObject<dynamic>(file));
        }
    
        private static WeatherResponse New(dynamic json)
        {
            try
            {
                return new WeatherResponse
                {
                    CityName = json.name,
                    CityId = json.id,
                    LocationLongitude = json.coord.lon,
                    LocationLatitude = json.coord.lat,
                    Title = json.weather[0].main,
                    Description = json.weather[0].description,
                    Temperature = json.main.temp,
                    AtmosphericPressure = json.main.pressure,
                    HumidityPercentage = json.main.humidity,
                    WindSpeed = json.wind.speed,
                    WindDirection = json.wind.deg,
                    CloudPercentage = json.clouds.all
                };
            }

            catch
            {
                throw new ArgumentException("The OpenWeatherMap API call was invalid, probably because of an invalid argument.");
            }
        }

        private static readonly HttpClient client = new HttpClient();
        internal static async Task<string> ReadWebpage(string uri)
        {
            HttpResponseMessage response = await client.GetAsync(uri);
            try { response.EnsureSuccessStatusCode(); }
            catch (HttpRequestException) 
            {
                switch (response.StatusCode)
                {
                    case HttpStatusCode.Unauthorized:
                        throw new ArgumentException("The given api key was invalid.");
                    
                    case HttpStatusCode.NotFound:
                        throw new ArgumentException("The location was not available.");
                    
                    case HttpStatusCode.TooManyRequests:
                        throw new HttpRequestException("The limit of 60 calls per minute was surpassed.");
                    
                    default:
                        throw new HttpRequestException("An internal error in OpenWeatherMap ocurred. It is recommended to contact OpenWeatherMap API in https://home.openweathermap.org/questions.");
                }
            }
            return await response.Content.ReadAsStringAsync();
        }
    }
}