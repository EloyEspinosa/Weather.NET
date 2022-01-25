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
    public WeatherClient(string apiKey)
    {
        ApiKey = apiKey;
    }
}