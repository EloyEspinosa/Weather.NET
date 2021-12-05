using Newtonsoft.Json;

namespace Weather.NET
{
    /// <summary>
    /// Provides the current weather of a specific location.
    /// OpenWeather docs: https://openweathermap.org/current
    /// </summary>
    public class CurrentWeather
    {
        /// <summary>
        /// Gets the current weather of a given city.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="cityName"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <exception cref="ArgumentException"></exception>
        public CurrentWeather(string cityName, string apiKey, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English)
        {
            string file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units={measurement}&lang={language}");
            dynamic json = JsonConvert.DeserializeObject<dynamic>(file);

            try
            {
                CityName = json.name;
                CityId = json.id;
                LocationLongitude = json.coord.lon;
                LocationLatitude = json.coord.lat;
                Title = json.weather[0].main;
                Description = json.weather[0].description;
                Temperature = json.main.temp;
                AtmosphericPressure = json.main.pressure;
                HumidityPercentage = json.main.humidity;
                WindSpeed = json.wind.speed;
                WindDirection = json.wind.deg;
                CloudPercentage = json.clouds.all;
            }

            catch
            {
                throw new ArgumentException("The OpenWeatherMap API call was invalid, probably because of an invalid argument.");
            }
        }

        /// <summary>
        /// Gets the current weather of a given city.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="cityId"> The OpenWeatherMap city ID. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <exception cref="ArgumentException"></exception>
        public CurrentWeather(long cityId, string apiKey, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English)
        {
            string file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?id={cityId}&appid={apiKey}&units={measurement}&lang={language}");
            dynamic json = JsonConvert.DeserializeObject<dynamic>(file);

            try
            {
                CityName = json.name;
                CityId = json.id;
                LocationLongitude = json.coord.lon;
                LocationLatitude = json.coord.lat;
                Title = json.weather[0].main;
                Description = json.weather[0].description;
                Temperature = json.main.temp;
                AtmosphericPressure = json.main.pressure;
                HumidityPercentage = json.main.humidity;
                WindSpeed = json.wind.speed;
                WindDirection = json.wind.deg;
                CloudPercentage = json.clouds.all;
            }

            catch
            {
                throw new ArgumentException("The OpenWeatherMap API call was invalid, probably because of an invalid argument.");
            }
        }

        /// <summary>
        /// Gets the current weather of a given location.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <exception cref="ArgumentException"></exception>
        public CurrentWeather(double latitude, double longitude, string apiKey, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English)
        {
            string file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}&units={measurement}&lang={language}");
            dynamic json = JsonConvert.DeserializeObject<dynamic>(file);

            try
            {
                CityName = json.name;
                CityId = json.id;
                LocationLongitude = json.coord.lon;
                LocationLatitude = json.coord.lat;
                Title = json.weather[0].main;
                Description = json.weather[0].description;
                Temperature = json.main.temp;
                AtmosphericPressure = json.main.pressure;
                HumidityPercentage = json.main.humidity;
                WindSpeed = json.wind.speed;
                WindDirection = json.wind.deg;
                CloudPercentage = json.clouds.all;
            }

            catch
            {
                throw new ArgumentException("The OpenWeatherMap API call was invalid, probably because of an invalid argument.");
            }
        }

        /// <summary>
        /// Gets the current weather of a given location.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zipCode"> The ZIP code of the location. </param>
        /// <param name="countryCode"> The ISO 3166 country code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <exception cref="ArgumentException"></exception>
        public CurrentWeather(long zipCode, string countryCode, string apiKey, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.Spanish)
        {
            string file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?zip={zipCode},{countryCode}&appid={apiKey}&units={measurement}&lang={language}");
            dynamic json = JsonConvert.DeserializeObject<dynamic>(file);

            try
            {
                CityName = json.name;
                CityId = json.id;
                LocationLongitude = json.coord.lon;
                LocationLatitude = json.coord.lat;
                Title = json.weather[0].main;
                Description = json.weather[0].description;
                Temperature = json.main.temp;
                AtmosphericPressure = json.main.pressure;
                HumidityPercentage = json.main.humidity;
                WindSpeed = json.wind.speed;
                WindDirection = json.wind.deg;
                CloudPercentage = json.clouds.all;
            }

            catch
            {
                throw new ArgumentException("The OpenWeatherMap API call was invalid, probably because of an invalid argument.");
            }
        }

        /// <summary>
        /// The name of the city analyzed.
        /// </summary>
        public string CityName { get; }

        /// <summary>
        /// The OpenWeatherMap city id of the city analyzed.
        /// More information in https://openweathermap.org/current#cityid.
        /// </summary>
        public long CityId { get; }

        /// <summary>
        /// The longitude of the location analyzed.
        /// </summary>
        public double LocationLongitude { get; }

        /// <summary>
        /// The latitude of the location analyzed.
        /// </summary>
        public double LocationLatitude { get; }

        /// <summary>
        /// An english word describing the current weather.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// A small description of the current weather in the specified language.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The temperature in the described measurement system.
        /// </summary>
        public double Temperature { get; }

        /// <summary>
        /// The atmopheric pressure represented in hPa.
        /// </summary>
        public int AtmosphericPressure { get; }

        /// <summary>
        /// The humidity of the location (%).
        /// </summary>
        public int HumidityPercentage { get; }

        /// <summary>
        /// The speed of the wind. Depends on the system of measurement.
        /// </summary>
        public double WindSpeed { get; }

        /// <summary>
        /// The direction of the wind in meteorological degrees.
        /// </summary>
        public int WindDirection { get; }

        /// <summary>
        /// The cloudiness percentage of the location (%).
        /// </summary>
        public int CloudPercentage { get; }

        private static string ReadWebpage(string uri)
        {
            try
            {
                var client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(uri).Result;
                response.EnsureSuccessStatusCode();
                client.Dispose();
                return response.Content.ReadAsStringAsync().Result;
            }

            catch (HttpRequestException e)
            {
                Console.WriteLine("\nInternal Http Request Exception Caught!");
                Console.WriteLine($"Message: {e.Message}");
                throw new HttpRequestException(e.Message);
            }
        }
    }
}