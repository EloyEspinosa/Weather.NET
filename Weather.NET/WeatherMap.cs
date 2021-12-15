namespace Weather.NET;

/// <summary>
/// Gets or downloads a OpenWeatherMap weather map (1.0).
/// More information in https://openweathermap.org/api/weathermaps
/// </summary>
public static class WeatherMap
{
    /// <summary>
    /// Gets the url of an OpenWeatherMap Weather Layer Map (1.0).
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="layer"> The type of map. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="xCoord"> The x coordinate of the map. </param>
    /// <param name="yCoord"> The y coordinate of the map. </param>
    /// <returns> The url of the map. </returns>
    public static string GetWeatherMapUrl(this WeatherClient client, MapLayer layer, int zoom, double xCoord, double yCoord) =>
        $"https://tile.openweathermap.org/map/{layer.Convert()}/{zoom}/{xCoord}/{yCoord}.png?appid={client.ApiKey}";

    /// <summary>
    /// Downloads an OpenWeatherMap Weather Layer Map (1.0).
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="fileName"> The file path where the map will be downloaded. </param>
    /// <param name="layer"> The type of map. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="xCoord"> The x coordinate of the map. </param>
    /// <param name="yCoord"> The y coordinate of the map. </param>
    public static void DownloadWeatherMap(this WeatherClient client, string fileName, MapLayer layer, int zoom, double xCoord, double yCoord) =>
        client.DownloadWeatherMapAsync(fileName, layer, zoom, xCoord, yCoord).Wait();

    /// <summary>
    /// Downloads an OpenWeatherMap Weather Layer Map (1.0) asynchronously.
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="fileName"> The file path where the map will be downloaded. </param>
    /// <param name="layer"> The type of map. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="xCoord"> The x coordinate of the map. </param>
    /// <param name="yCoord"> The y coordinate of the map. </param>
    /// <returns> A task of the download. </returns>
    public static async Task DownloadWeatherMapAsync(this WeatherClient client, string fileName, MapLayer layer, int zoom, double xCoord, double yCoord)
    {
        Stream stream = await (await WeatherClient.GetWebpageAsync(client.GetWeatherMapUrl(layer, zoom, xCoord, yCoord))).Content.ReadAsStreamAsync();
        try
        {
            using (var fileStream = new FileStream(fileName, FileMode.CreateNew))
            {
                await stream.CopyToAsync(fileStream);
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine("An error ocurred while trying to download the weather map.");
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}