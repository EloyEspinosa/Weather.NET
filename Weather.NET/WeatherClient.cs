global using System.Net;
global using Newtonsoft.Json;
global using Weather.NET.Enums;
global using Weather.NET.Exceptions;
global using Weather.NET.Extensions;
global using Weather.NET.Models.WeatherModel;

namespace Weather.NET;

/// <summary>
/// The client that can get the current and future weather, among other things.
/// </summary>
public class WeatherClient
{
    /// <summary>
    /// The API key of the user.
    /// </summary>
    public string ApiKey { get; set; }

    /// <summary>
    /// Creates a new WeatherClient.
    /// </summary>
    /// <param name="apiKey"> The api key of the user. </param>
    /// <param name="defaultMeasurement"> The default measurement system of the user. </param>
    /// <param name="defaultLanguage"> The default language of the user. </param>
    public WeatherClient(string apiKey)
    {
        ApiKey = apiKey;
    }

    /// <summary>
    /// Gets a webpage and returns the response asynchronously, handling error codes.
    /// </summary>
    /// <param name="url"> The url of the webpage. </param>
    /// <returns> An HttpResponseMessage without an error as a status code. </returns>
    /// <exception cref="HttpBadRequestException"></exception>
    /// <exception cref="HttpUnauthorizedException"></exception>
    /// <exception cref="HttpNotFoundException"></exception>
    /// <exception cref="HttpTooManyRequestsException"></exception>
    /// <exception cref="HttpRequestException"></exception>
    public static async Task<HttpResponseMessage> GetWebpageAsync(string url)
    {
        HttpResponseMessage response = await client.GetAsync(url);
        try { response.EnsureSuccessStatusCode(); }
        catch (HttpRequestException)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                    string message = (JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync())).message;
                    throw new HttpBadRequestException(message);

                case HttpStatusCode.Unauthorized:
                    throw new HttpUnauthorizedException("The given api key was invalid.");

                case HttpStatusCode.NotFound:
                    throw new HttpNotFoundException("The location was not available.");
                
                case HttpStatusCode.TooManyRequests:
                    throw new HttpTooManyRequestsException("The limit of calls per minute for your subscription was surpassed.");
                
                default:
                    throw new HttpRequestException("An internal error in OpenWeatherMap ocurred. It is recommended to contact OpenWeatherMap API in https://home.openweathermap.org/questions.");
            }
        }

        return response;
    }

    /// <summary>
    /// Gets a webpage and returns the response, handling error codes.
    /// </summary>
    /// <param name="url"> The url of the webpage. </param>
    /// <returns> An HttpResponseMessage without an error as a status code. </returns>
    public static HttpResponseMessage GetWebpage(string url) => GetWebpageAsync(url).Result;

    /// <summary>
    /// Gets a webpage and returns it as a string asynchronously, handling error codes.
    /// </summary>
    /// <param name="url"> The url of the webpage. </param>
    /// <returns> The webpage as a string. </returns>
    public static async Task<string> GetWebpageStringAsync(string url) =>
        await (await GetWebpageAsync(url)).Content.ReadAsStringAsync();

    /// <summary>
    /// Gets a webpage and returns it as a string, handling error codes.
    /// </summary>
    /// <param name="url"> The url of the webpage. </param>
    /// <returns> The webpage as a string. </returns>
    public static string GetWebpageString(string url) => GetWebpageStringAsync(url).Result;

    /// <summary>
    /// Gets a webpage and returns it as a stream of characters asynchronously, handling error codes.
    /// </summary>
    /// <param name="url"> The url of the webpage. </param>
    /// <returns> The webpage as a stream of characters. </returns>
    public static async Task<Stream> GetWebpageStreamAsync(string url) =>
        await (await GetWebpageAsync(url)).Content.ReadAsStreamAsync();

    /// <summary>
    /// Gets a webpage and returns it as a stream of characters, handling error codes.
    /// </summary>
    /// <param name="url"> The url of the webpage. </param>
    /// <returns> The webpage as a stream of characters. </returns>
    public static Stream GetWebpageStream(string url) => GetWebpageStreamAsync(url).Result;

    private static readonly HttpClient client = new HttpClient();
}