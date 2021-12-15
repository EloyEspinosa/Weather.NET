namespace Weather.NET;

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
    /// <param name="measurement"> The measurement system used in the output. </param>
    /// <param name="language"> The language of the output. </param>
    /// <returns> A list of weather responses, with their exact moment. </returns>
    public static List<WeatherModel> New(string cityName, string apiKey, int timestampCount = 96, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
        NewAsync(cityName, apiKey, timestampCount, measurement, language).Result;

    /// <summary>
    /// Gets a 5 day / 3 hour weather forecast of a specific location.
    /// More information in https://openweathermap.org/forecast5#cityid5
    /// </summary>
    /// <param name="cityId"> The OpenWeather city ID. </param>
    /// <param name="apiKey"> The api key of the user. </param>
    /// <param name="timestampCount"> The number of forecasts in the output. </param>
    /// <param name="measurement"> The measuremnt system used in the output. </param>
    /// <param name="language"> The language of the output. </param>
    /// <returns> A list of weather responses, with their exact moment. </returns>
    public static List<WeatherModel> New(long cityId, string apiKey, int timestampCount = 96, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
        NewAsync(cityId, apiKey, timestampCount, measurement, language).Result;

    /// <summary>
    /// Gets a 5 day / 3 hour weather forecast of a specific location.
    /// More information in https://openweathermap.org/forecast5#geo5
    /// </summary>
    /// <param name="latitude"> The latitude of the location. </param>
    /// <param name="longitude"> The longitude of the location. </param>
    /// <param name="apiKey"> The api key of the user. </param>
    /// <param name="timestampCount"> The number of forecasts in the output. </param>
    /// <param name="measurement"> The measurement system used in the output. </param>
    /// <param name="language"> The language of the output. </param>
    /// <returns> A list of weather responses, with their exact moment. </returns>
    public static List<WeatherModel> New(double latitude, double longitude, string apiKey, int timestampCount = 96, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
        NewAsync(latitude, longitude, apiKey, timestampCount, measurement, language).Result;

    /// <summary>
    /// Gets a 5 day / 3 hour weather forecast of a specific location.
    /// More information in https://openweathermap.org/forecast5#zip5
    /// </summary>
    /// <param name="zipCode"> The ZIP code of the location. </param>
    /// <param name="countryCode"> The country code of the location. </param>
    /// <param name="apiKey"> The api key of the user. </param>
    /// <param name="timestampCount"> The number of forecasts in the output. </param>
    /// <param name="measurement"> The measurement system used in the output. </param>
    /// <param name="language"> The language of the output. </param>
    /// <returns> A list of weather responses, with their exact moment. </returns>
    public static List<WeatherModel> New(long zipCode, string countryCode, string apiKey, int timestampCount = 96, Measurement measurement = Measurement.Standard, Language language = Language.English)
    {
        string file = CurrentWeather.ReadWebpage($"https://api.openweathermap.org/data/2.5/forecast?zip={zipCode},{countryCode}&appid={apiKey}&cnt={timestampCount}&units={measurement.Convert()}&lang={language.Convert()}").Result;
        return New(JsonConvert.DeserializeObject<dynamic>(file));
    }

    /// <summary>
    /// Gets a 5 day / 3 hour weather forecast of a specific location asynchronously.
    /// More information in https://openweathermap.org/forecast5#name5
    /// </summary>
    /// <param name="cityName"> The name of the city. </param>
    /// <param name="apiKey"> The api key of the user. </param>
    /// <param name="timestampCount"> The number of forecasts in the output. </param>
    /// <param name="measurement"> The measurement system used in the output. </param>
    /// <param name="language"> The language of the output. </param>
    /// <returns> A list of weather responses, with their exact moment. </returns>
    public static async Task<List<WeatherModel>> NewAsync(string cityName, string apiKey, int timestampCount = 96, Measurement measurement = Measurement.Standard, Language language = Language.English)
    {
        string file = await CurrentWeather.ReadWebpage($"https://api.openweathermap.org/data/2.5/forecast?q={cityName}&appid={apiKey}&cnt={timestampCount}&units={measurement.Convert()}&lang={language.Convert()}");
        return New(JsonConvert.DeserializeObject<dynamic>(file));
    }

    /// <summary>
    /// Gets a 5 day / 3 hour weather forecast of a specific location asynchronously.
    /// More information in https://openweathermap.org/forecast5#cityid5
    /// </summary>
    /// <param name="cityId"> The OpenWeather city ID. </param>
    /// <param name="apiKey"> The api key of the user. </param>
    /// <param name="timestampCount"> The number of forecasts in the output. </param>
    /// <param name="measurement"> The measuremnt system used in the output. </param>
    /// <param name="language"> The language of the output. </param>
    /// <returns> A list of weather responses, with their exact moment. </returns>
    public static async Task<List<WeatherModel>> NewAsync(long cityId, string apiKey, int timestampCount = 96, Measurement measurement = Measurement.Standard, Language language = Language.English)
    {
        string file = await CurrentWeather.ReadWebpage($"https://api.openweathermap.org/data/2.5/forecast?id={cityId}&appid={apiKey}&cnt={timestampCount}&units={measurement.Convert()}&lang={language.Convert()}");
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
    /// <param name="measurement"> The measurement system used in the output. </param>
    /// <param name="language"> The language of the output. </param>
    /// <returns> A list of weather responses, with their exact moment. </returns>
    public static async Task<List<WeatherModel>> NewAsync(double latitude, double longitude, string apiKey, int timestampCount = 96, Measurement measurement = Measurement.Standard, Language language = Language.English)
    {
        string file = await CurrentWeather.ReadWebpage($"https://api.openweathermap.org/data/2.5/forecast?lat={latitude}&lon={longitude}&appid={apiKey}&cnt={timestampCount}&units={measurement.Convert()}&lang={language.Convert()}");
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
    /// <param name="measurement"> The measurement system used in the output. </param>
    /// <param name="language"> The language of the output. </param>
    /// <returns> A list of weather responses, with their exact moment. </returns>
    public static async Task<List<WeatherModel>> NewAsync(long zipCode, string countryCode, string apiKey, int timestampCount = 96, Measurement measurement = Measurement.Standard, Language language = Language.English)
    {
        string file = await CurrentWeather.ReadWebpage($"https://api.openweathermap.org/data/2.5/forecast?zip={zipCode},{countryCode}&appid={apiKey}&cnt={timestampCount}&units={measurement.Convert()}&lang={language.Convert()}");
        return New(JsonConvert.DeserializeObject<dynamic>(file));
    }

    private static List<WeatherModel> New(dynamic json)
    {
        var output = new List<WeatherModel>();
        foreach (var item in json.list)
        {
            output.Add(new WeatherModel
            {
                Location = new Location { Longitude = json.city.coord.lon, Latitude = json.city.coord.lat },

                Weather = new List<Models.WeatherModel.Weather> {
                new Models.WeatherModel.Weather {
                    Id = item.weather[0].id,
                    Title = item.weather[0].main,
                    Description = item.weather[0].description,
                    IconId = item.weather[0].icon,
                }},

                Main = new Main
                {
                    Temperature = item.main.temp,
                    TemperaturePerception = item.main.feels_like,
                    TemperatureMin = item.main.temp_min,
                    TemperatureMax = item.main.temp_max,
                    AtmosphericPressure = item.main.pressure,
                    HumidityPercentage = item.main.humidity
                },

                Visibility = item.visibility,
                Wind = new Wind { Speed = item.wind.speed, Direction = item.wind.deg },
                Clouds = new Clouds { Percentage = item.clouds.all },
                AnalysisDate = item.dt,

                Internal = new Internal
                {
                    Message = json.message,
                    Country = json.city.country,
                    SunriseUnix = json.city.sunrise,
                    SunsetUnix = json.city.sunset
                },
                
                Timezone = json.city.timezone,
                CityId = json.city.id,
                CityName = json.city.name,
                Cod = json.cod
            });
        }

        return output;
    }
}