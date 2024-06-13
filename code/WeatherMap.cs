using System.Reflection.Emit;

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
    /// <param name="xCoord"> The x tile coordinate of the map. </param>
    /// <param name="yCoord"> The y tile coordinate of the map. </param>
    /// <returns> The url of the map. </returns>
    public static string GetWeatherMapUrl(this WeatherClient client, MapLayer layer, int zoom, int xCoord, int yCoord) =>
        $"https://tile.openweathermap.org/map/{layer.Convert()}/{zoom}/{xCoord}/{yCoord}.png?appid={client.ApiKey}";

    /// <summary>
    /// Gets the url of an OpenWeatherMap Weather Layer Map (1.0).
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="layer"> The type of map. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="latitude"> Latitude. </param>
    /// <param name="longitude"> Longitude. </param>
    /// <returns> The url of the map. </returns>
    public static string GetWeatherMapUrl(this WeatherClient client, MapLayer layer, int zoom, double latitude, double longitude)
    {
        var tileCoordinates = LatLongToTileCoordinates(zoom, latitude, longitude);
        return client.GetWeatherMapUrl(layer, zoom, tileCoordinates.x, tileCoordinates.y);
    }

    /// <summary>
    /// Downloads an OpenWeatherMap Weather Layer Map (1.0).
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="fileName"> The file path where the map will be downloaded. </param>
    /// <param name="layer"> The type of map. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="xCoord"> The x tile coordinate of the map. </param>
    /// <param name="yCoord"> The y tile coordinate of the map. </param>
    public static void DownloadWeatherMap(this WeatherClient client, string fileName, MapLayer layer, int zoom, int xCoord, int yCoord) =>
        Task.Run(() => client.DownloadWeatherMapAsync(fileName, layer, zoom, xCoord, yCoord)).Wait();

    /// <summary>
    /// Downloads an OpenWeatherMap Weather Layer Map (1.0).
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="fileName"> The file path where the map will be downloaded. </param>
    /// <param name="layer"> The type of map. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="latitude"> Latitude. </param>
    /// <param name="longitude"> Longitude. </param>
    public static void DownloadWeatherMap(this WeatherClient client, string fileName, MapLayer layer, int zoom, double latitude, double longitude) =>
        Task.Run(() => client.DownloadWeatherMapAsync(fileName, layer, zoom, latitude, longitude)).Wait();

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
    public static async Task DownloadWeatherMapAsync(this WeatherClient client, string fileName, MapLayer layer, int zoom, int xCoord, int yCoord)
    {
        await DownloadUrl(fileName, client.GetWeatherMapUrl(layer, zoom, xCoord, yCoord));
    }

    /// <summary>
    /// Downloads an OpenWeatherMap Weather Layer Map (1.0) asynchronously.
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="fileName"> The file path where the map will be downloaded. </param>
    /// <param name="layer"> The type of map. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="latitude"> Latitude. </param>
    /// <param name="longitude"> Longitude. </param>
    /// <returns> A task of the download. </returns>
    public static async Task DownloadWeatherMapAsync(this WeatherClient client, string fileName, MapLayer layer, int zoom, double latitude, double longitude)
    {
        await DownloadUrl(fileName, client.GetWeatherMapUrl(layer, zoom, latitude, longitude));
    }

    private static async Task DownloadUrl(string fileName, string url)
    {
        // Copy the Webpage a stream of characters to a new file.
        Stream stream = await RestApi.GetWebpageStreamAsync(url);
        try
        {
            using (var fileStream = new FileStream(fileName, FileMode.CreateNew))
            {
                await stream.CopyToAsync(fileStream);
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while trying to download the weather map.");
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }

    /// <summary>
    /// Gets the url of an OpenStreetMap Base Map
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="xCoord"> The x tile coordinate of the map. </param>
    /// <param name="yCoord"> The y tile coordinate of the map. </param>
    /// <returns> The url of the map. </returns>
    public static string GetStreetMapUrl(this WeatherClient client, int zoom, int xCoord, int yCoord) =>
        $"https://tile.openstreetmap.org/{zoom}/{xCoord}/{yCoord}.png";

    /// <summary>
    /// Gets the url of an OpenStreetMap Base Map
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="latitude"> Latitude. </param>
    /// <param name="longitude"> Longitude. </param>
    /// <returns> The url of the map. </returns>
    public static string GetStreetMapUrl(this WeatherClient client, int zoom, double latitude, double longitude)
    {
        var tileCoordinates = LatLongToTileCoordinates(zoom, latitude, longitude);
        return client.GetStreetMapUrl(zoom, tileCoordinates.x, tileCoordinates.y);
    }

    /// <summary>
    /// Downloads an OpenStreetMap Base Map
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="fileName"> The file path where the map will be downloaded. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="xCoord"> The x tile coordinate of the map. </param>
    /// <param name="yCoord"> The y tile coordinate of the map. </param>
    public static void DownloadStreetMap(this WeatherClient client, string fileName, int zoom, int xCoord, int yCoord) =>
        Task.Run(() => client.DownloadStreetMapAsync(fileName, zoom, xCoord, yCoord));

    /// <summary>
    /// Downloads an OpenStreetMap Base Map
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="fileName"> The file path where the map will be downloaded. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="latitude"> Latitude. </param>
    /// <param name="longitude"> Longitude. </param>
    public static void DownloadStreetMap(this WeatherClient client, string fileName, int zoom, double latitude, double longitude) =>
        Task.Run(() => client.DownloadStreetMapAsync(fileName, zoom, latitude, longitude)).Wait();

    /// <summary>
    /// Downloads an OpenStreetMap Base Map asynchronously.
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="fileName"> The file path where the map will be downloaded. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="xCoord"> The x coordinate of the map. </param>
    /// <param name="yCoord"> The y coordinate of the map. </param>
    /// <returns> A task of the download. </returns>
    public static async Task DownloadStreetMapAsync(this WeatherClient client, string fileName, int zoom, int xCoord, int yCoord)
    {
        await DownloadUrl(fileName, client.GetStreetMapUrl(zoom, xCoord, yCoord));
    }

    /// <summary>
    /// Downloads an OpenStreetMap Base Map asynchronously.
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="fileName"> The file path where the map will be downloaded. </param>
    /// <param name="zoom"> The level of zoom of the map. </param>
    /// <param name="latitude"> Latitude. </param>
    /// <param name="longitude"> Longitude. </param>
    /// <returns> A task of the download. </returns>
    public static async Task DownloadStreetMapAsync(this WeatherClient client, string fileName, int zoom, double latitude, double longitude)
    {
        await DownloadUrl(fileName, client.GetStreetMapUrl(zoom, latitude, longitude));
    }

    public static (int x, int y) LatLongToTileCoordinates(int zoomLevel, double latitude, double longitude, int tileSizeInPoints = 256)
    {
        double latRad = latitude * Math.PI / 180;
        double n = Math.Pow(2, zoomLevel);
        int x = (int)Math.Floor((longitude + 180.0) / 360.0 * n);
        int y = (int)Math.Floor((1.0 - Math.Log(Math.Tan(latRad) + 1.0 / Math.Cos(latRad)) / Math.PI) / 2.0 * n);

        return (x, y);
    }
}