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
    /// The default system of measurement.
    /// </summary>
    public Measurement Measurement { get; set; }

    /// <summary>
    /// The default language.
    /// </summary>
    public Language Language { get; set; }

    /// <summary>
    /// Creates a new WeatherClient.
    /// </summary>
    /// <param name="apiKey"> The api key of the user. </param>
    /// <param name="defaultMeasurement"> The default measurement system of the user. </param>
    /// <param name="defaultLanguage"> The default language of the user. </param>
    public WeatherClient(string apiKey, Measurement defaultMeasurement = Measurement.Standard, Language defaultLanguage = Language.English)
    {
        ApiKey = apiKey;
        Measurement = defaultMeasurement;
        Language = defaultLanguage;
    }

    /// <summary>
    /// Gets a webpage and returns the response, handling error codes.
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

    private static readonly HttpClient client = new HttpClient();
}