namespace Weather.NET
{
    /// <summary>
    /// Provides a 5 day / 3 hour weather forecast of a specific location.
    /// OpenWeatherMap docs: https://openweathermap.org/forecast5
    /// </summary>
    public static class FutureWeather
    {
        /// <summary>
        /// Gets a 5 day / 3 hour weather forecast of a specific location.
        /// More information in https://openweathermap.org/forecast5#name5
        /// </summary>
        /// <param name="cityName"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="timestampCount"> The number of forecasts in the output. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <returns> A list of weather responses, with their exact moment. </returns>
        public static List<(DateTimeOffset, WeatherResponse)> New(string cityName, string apiKey, int timestampCount = 96, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English) =>
            NewAsync(cityName, apiKey, timestampCount, measurement, language).Result;

        /// <summary>
        /// Gets a 5 day / 3 hour weather forecast of a specific location.
        /// More information in https://openweathermap.org/forecast5#cityid5
        /// </summary>
        /// <param name="cityId"> The OpenWeather city ID. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="timestampCount"> The number of forecasts in the output. </param>
        /// <param name="measurement"> The measuremnt system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <returns> A list of weather responses, with their exact moment. </returns>
        public static List<(DateTimeOffset, WeatherResponse)> New(long cityId, string apiKey, int timestampCount = 96, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English) =>
            NewAsync(cityId, apiKey, timestampCount, measurement, language).Result;

        /// <summary>
        /// Gets a 5 day / 3 hour weather forecast of a specific location.
        /// More information in https://openweathermap.org/forecast5#geo5
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="timestampCount"> The number of forecasts in the output. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <returns> A list of weather responses, with their exact moment. </returns>
        public static List<(DateTimeOffset, WeatherResponse)> New(double latitude, double longitude, string apiKey, int timestampCount = 96, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English) =>
            NewAsync(latitude, longitude, apiKey, timestampCount, measurement, language).Result;

        /// <summary>
        /// Gets a 5 day / 3 hour weather forecast of a specific location.
        /// More information in https://openweathermap.org/forecast5#zip5
        /// </summary>
        /// <param name="zipCode"> The ZIP code of the location. </param>
        /// <param name="countryCode"> The country code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="timestampCount"> The number of forecasts in the output. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <returns> A list of weather responses, with their exact moment. </returns>
        public static List<(DateTimeOffset, WeatherResponse)> New(long zipCode, string countryCode, string apiKey, int timestampCount = 96, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English) =>
            NewAsync(zipCode, countryCode, timestampCount, measurement, language).Result;

        /// <summary>
        /// Gets a 5 day / 3 hour weather forecast of a specific location asynchronously.
        /// More information in https://openweathermap.org/forecast5#name5
        /// </summary>
        /// <param name="cityName"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="timestampCount"> The number of forecasts in the output. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <returns> A list of weather responses, with their exact moment. </returns>
        public static async Task<List<(DateTimeOffset, WeatherResponse)>> NewAsync(string cityName, string apiKey, int timestampCount = 96, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English)
        {
            string file = await CurrentWeather.ReadWebpage($"https://api.openweathermap.org/data/2.5/forecast?q={cityName}&appid={apiKey}&cnt={timestampCount}&units={measurement}&lang={language}");
            return New(JsonConvert.DeserializeObject<dynamic>(file));
        }

        /// <summary>
        /// Gets a 5 day / 3 hour weather forecast of a specific location asynchronously.
        /// More information in https://openweathermap.org/forecast5#cityid5
        /// </summary>
        /// <param name="cityId"> The OpenWeather city ID. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="timestampCount"> The number of forecasts in the output. </param>
        /// <param name="measurement"> The measuremnt system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <returns> A list of weather responses, with their exact moment. </returns>
        public static async Task<List<(DateTimeOffset, WeatherResponse)>> NewAsync(long cityId, string apiKey, int timestampCount = 96, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English)
        {
            string file = await CurrentWeather.ReadWebpage($"https://api.openweathermap.org/data/2.5/forecast?id={cityId}&appid={apiKey}&cnt={timestampCount}&units={measurement}&lang={language}");
            return New(JsonConvert.DeserializeObject<dynamic>(file));
        }

        /// <summary>
        /// Gets a 5 day / 3 hour weather forecast of a specific location asynchronously.
        /// More information in https://openweathermap.org/forecast5#geo5
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="timestampCount"> The number of forecasts in the output. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <returns> A list of weather responses, with their exact moment. </returns>
        public static async Task<List<(DateTimeOffset, WeatherResponse)>> NewAsync(double latitude, double longitude, string apiKey, int timestampCount = 96, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English)
        {
            string file = await CurrentWeather.ReadWebpage($"https://api.openweathermap.org/data/2.5/forecast?lat={latitude}&lon={longitude}&appid={apiKey}&cnt={timestampCount}&units={measurement}&lang={language}");
            return New(JsonConvert.DeserializeObject<dynamic>(file));
        }

        /// <summary>
        /// Gets a 5 day / 3 hour weather forecast of a specific location asynchronously.
        /// More information in https://openweathermap.org/forecast5#zip5
        /// </summary>
        /// <param name="zipCode"> The ZIP code of the location. </param>
        /// <param name="countryCode"> The country code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="timestampCount"> The number of forecasts in the output. </param>
        /// <param name="measurement"> The measurement system used in the output, can be any of the constants in WeatherMeasurement. </param>
        /// <param name="language"> The language of the output, can be any of the constants in WeatherLanguage. </param>
        /// <returns> A list of weather responses, with their exact moment. </returns>
        public static async Task<List<(DateTimeOffset, WeatherResponse)>> NewAsync(long zipCode, string countryCode, string apiKey, int timestampCount = 96, string measurement = WeatherMeasurement.Standard, string language = WeatherLanguage.English)
        {
            string file = await CurrentWeather.ReadWebpage($"https://api.openweathermap.org/data/2.5/forecast?zip={zipCode},{countryCode}&appid={apiKey}&cnt={timestampCount}&units={measurement}&lang={language}");
            return New(JsonConvert.DeserializeObject<dynamic>(file));
        }

        private static List<(DateTimeOffset, WeatherResponse)> New(dynamic json)
        {
            try
            {
                var output = new List<(DateTimeOffset, WeatherResponse)>();
                foreach (var item in json.list)
                {
                    output.Add
                    (
                        (DateTimeOffset.FromUnixTimeSeconds((long) item.dt),
                        new WeatherResponse
                        {
                            CityName = json.city.name,
                            CityId = json.city.id,
                            LocationLongitude = json.city.coord.lon,
                            LocationLatitude = json.city.coord.lat,
                            Title = item.weather[0].main,
                            Description = item.weather[0].description,
                            Temperature = item.main.temp,
                            AtmosphericPressure = item.main.pressure,
                            HumidityPercentage = item.main.humidity,
                            WindSpeed = item.wind.speed,
                            WindDirection = item.wind.deg,
                            CloudPercentage = item.clouds.all
                        })
                    );
                }

                return output;
            }

            catch
            {
                throw new ArgumentException("The OpenWeatherMap API call was invalid, probably because of an invalid argument.");
            }
        }
    }
}