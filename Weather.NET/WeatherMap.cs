namespace Weather.NET
{
    /// <summary>
    /// Gets or downloads a OpenWeatherMap weather map (1.0).
    /// More information in https://openweathermap.org/api/weathermaps
    /// </summary>
    public static class WeatherMap
    {
        /// <summary>
        /// Gets the url of a weather map.
        /// More information in https://openweathermap.org/api/weathermaps#urlformat
        /// </summary>
        /// <param name="layer"> The type of map layer. </param>
        /// <param name="zoom"> The zoom level of the map. </param>
        /// <param name="xCoord"> The x tile coordinate of the map. </param>
        /// <param name="yCoord"> The y tile coordinate of the map. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <returns> The url of the map. </returns>
        public static string GetMapUrl(MapLayer layer, int zoom, double xCoord, double yCoord, string apiKey) =>
            $"https://tile.openweathermap.org/map/{layer.Convert()}/{zoom}/{xCoord}/{yCoord}.png?appid={apiKey}";
        
        /// <summary>
        /// Downloads a weather map in a given file path.
        /// More information in https://openweathermap.org/api/weathermaps#urlformat
        /// </summary>
        /// <param name="fileName"> The path of the new file. </param>
        /// <param name="layer"> The type of map layer. </param>
        /// <param name="zoom"> The zoom level of the map. </param>
        /// <param name="xCoord"> The x coordinate of the map. </param>
        /// <param name="yCoord"> The y coordinate of the map. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        public static void DownloadMap(string fileName, MapLayer layer, int zoom, double xCoord, double yCoord, string apiKey) =>
            DownloadMapAsync(fileName, layer, zoom, xCoord, yCoord, apiKey).Wait();

        /// <summary>
        /// Downloads a weather map in a given file path asynchronously.
        /// More information in https://openweathermap.org/api/weathermaps#urlformat
        /// </summary>
        /// <param name="fileName"> The path of the new file. </param>
        /// <param name="layer"> The type of map layer. </param>
        /// <param name="zoom"> The zoom level of the map. </param>
        /// <param name="xCoord"> The x coordinate of the map. </param>
        /// <param name="yCoord"> The y coordinate of the map. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        public static async Task DownloadMapAsync(string fileName, MapLayer layer, int zoom, double xCoord, double yCoord, string apiKey)
        {
            Stream stream = await client.GetStreamAsync(GetMapUrl(layer, zoom, xCoord, yCoord, apiKey));
            using (var fileStream = new FileStream(fileName, FileMode.CreateNew))
            {
                await stream.CopyToAsync(fileStream);
            }
        }

        private static readonly HttpClient client = new HttpClient();
    }
}