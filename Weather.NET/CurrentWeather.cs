global using System.Net;
global using Newtonsoft.Json;
global using Weather.NET.Enums;
global using Weather.NET.Exceptions;
global using Weather.NET.Extensions;
global using Weather.NET.Models.WeatherModel;

namespace Weather.NET;

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
    public static WeatherModel New(string cityName, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
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
    public static WeatherModel New(long cityId, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
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
    public static WeatherModel New(double latitude, double longitude, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
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
    public static WeatherModel New(long zipCode, string countryCode, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English) =>
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
    public static async Task<WeatherModel> NewAsync(string cityName, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English)
    {
        string file = await ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units={measurement.Convert()}&lang={language.Convert()}");
        return JsonConvert.DeserializeObject<WeatherModel>(file);
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
    public static async Task<WeatherModel> NewAsync(long cityId, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English)
    {
        string file = await ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?id={cityId}&appid={apiKey}&units={measurement.Convert()}&lang={language.Convert()}");
        return JsonConvert.DeserializeObject<WeatherModel>(file);
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
    public static async Task<WeatherModel> NewAsync(double latitude, double longitude, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English)
    {
        string file = await ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}&units={measurement.Convert()}&lang={language.Convert()}");
        return JsonConvert.DeserializeObject<WeatherModel>(file);
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
    public static async Task<WeatherModel> NewAsync(long zipCode, string countryCode, string apiKey, Measurement measurement = Measurement.Standard, Language language = Language.English)
    {
        string file = await ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?zip={zipCode},{countryCode}&appid={apiKey}&units={measurement.Convert()}&lang={language.Convert()}");
        return JsonConvert.DeserializeObject<WeatherModel>(file);
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
                    throw new HttpUnauthorizedException("The given api key was invalid.");

                case HttpStatusCode.NotFound:
                    throw new HttpNotFoundException("The location was not available.");

                case HttpStatusCode.TooManyRequests:
                    throw new HttpTooManyRequestsException("The limit of 60 calls per minute was surpassed.");

                default:
                    throw new HttpRequestException("An internal error in OpenWeatherMap ocurred. It is recommended to contact OpenWeatherMap API in https://home.openweathermap.org/questions.");
            }
        }
        return await response.Content.ReadAsStringAsync();
    }
}