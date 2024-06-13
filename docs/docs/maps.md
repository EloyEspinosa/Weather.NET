## WeatherMap
This class provides extension methods for WeatherClient that get layer maps of the weather.

### Functions
*LatLongToTileCoordinates(zoom, latitude, longitude)*: Converts latitude and longitude to tile coordinates.
- *zoom* (int): The level of zoom of the map.
- *latitude* (double): Latitude.
- *longitude* (double): Longitude.
- *returns* ((int, int)): The pair of tile coordinates.

### Methods
*WeatherClient.GetWeatherMapUrl(layer, zoom, latitude, longitude)*: Gets the url of an OpenWeatherMap Weather Layer Map (1.0).
- *layer* (Enums.MapLayer): The type of map.
- *zoom* (int): The level of zoom of the map.
- *latitude* (double): Latitude.
- *longitude* (double): Longitude.
- *returns* (string): The url of the map.

*WeatherClient.GetWeatherMapUrl(layer, zoom, xCoord, yCoord)*: Gets the url of an OpenWeatherMap Weather Layer Map (1.0).
- *layer* (Enums.MapLayer): The type of map.
- *zoom* (int): The level of zoom of the map.
- *xCoord* (int): The x tile coordinate of the map.
- *yCoord* (int): The y tile coordinate of the map.
- *returns* (string): The url of the map.

*WeatherClient.DownloadWeatherMap(fileName, layer, zoom, latitude, longitude)*: Downloads an OpenWeatherMap Weather Layer Map (1.0).
- *fileName* (string): The file path where the map will be downloaded.
- *layer* (Enums.MapLayer): The type of map.
- *zoom* (int): The level of zoom of the map.
- *latitude* (double): Latitude.
- *longitude* (double): Longitude.

*WeatherClient.DownloadWeatherMap(fileName, layer, zoom, xCoord, yCoord)*: Downloads an OpenWeatherMap Weather Layer Map (1.0).
- *fileName* (string): The file path where the map will be downloaded.
- *layer* (Enums.MapLayer): The type of map.
- *zoom* (int): The level of zoom of the map.
- *xCoord* (int): The x tile coordinate of the map.
- *yCoord* (int): The y tile coordinate of the map.

*WeatherClient.GetStreetMapUrl(zoom, latitude, longitude)*:
Gets the url of an OpenStreetMap Base Map.
- *zoom* (int): The level of zoom of the map.
- *latitude* (double): Latitude.
- *longitude* (double): Longitude.
- *returns* (string): The url of the map.

*WeatherClient.GetStreetMapUrl(zoom, xCoord, yCoord)*:
Gets the url of an OpenStreetMap Base Map.
- *zoom* (int): The level of zoom of the map.
- *xCoord* (int): The x tile coordinate of the map.
- *yCoord* (int): The y tile coordinate of the map.
- *returns* (string): The url of the map.

*WeatherClient.DownloadStreetMap(fileName, zoom, latitude, longitude)*:
Downloads an OpenStreetMap Base Map.
- *fileName* (string): The file path where the map will be downloaded.
- *zoom* (int): The level of zoom of the map.
- *latitude* (double): Latitude.
- *longitude* (double): Longitude.

*WeatherClient.DownloadStreetMap(fileName, zoom, xCoord, yCoord)*:
Downloads an OpenStreetMap Base Map.
- *fileName* (string): The file path where the map will be downloaded.
- *zoom* (int): The level of zoom of the map.
- *xCoord* (int): The x tile coordinate of the map.
- *yCoord* (int): The y tile coordinate of the map.

*WeatherClient.DownloadWeatherMapAsync(fileName, layer, zoom, latitude, longitude)*: Downloads an OpenWeatherMap Weather Layer Map (1.0) asynchronously.
- *fileName* (string): The file path where the map will be downloaded.
- *layer* (Enums.MapLayer): The type of map.
- *zoom* (int): The level of zoom of the map.
- *latitude* (double): Latitude.
- *longitude* (double): Longitude.
- *returns* (Task): A task of the download.

*WeatherClient.DownloadWeatherMapAsync(fileName, layer, zoom, xCoord, yCoord)*: Downloads an OpenWeatherMap Weather Layer Map (1.0) asynchronously.
- *fileName* (string): The file path where the map will be downloaded.
- *layer* (Enums.MapLayer): The type of map.
- *zoom* (int): The level of zoom of the map.
- *xCoord* (int): The x tile coordinate of the map.
- *yCoord* (int): The y tile coordinate of the map.
- *returns* (Task): A task of the download.

*WeatherClient.DownloadStreetMapAsync(fileName, zoom, latitude, longitude)*:
Downloads an OpenStreetMap Base Map asynchronously.
- *fileName* (string): The file path where the map will be downloaded.
- *zoom* (int): The level of zoom of the map.
- *latitude* (double): Latitude.
- *longitude* (double): Longitude.
- *returns* (Task): A task of the download.

*WeatherClient.DownloadStreetMapAsync(fileName, zoom, xCoord, yCoord)*:
Downloads an OpenStreetMap Base Map asynchronously.
- *fileName* (string): The file path where the map will be downloaded.
- *zoom* (int): The level of zoom of the map.
- *xCoord* (int): The x tile coordinate of the map.
- *yCoord* (int): The y tile coordinate of the map.
- *returns* (Task): A task of the download.

[Back](https://eloyespinosa.github.io/Weather.NET/docs/)
