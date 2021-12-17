## WeatherMap
This class provides extension methods for WeatherClient that get layer maps of the weather.
### Methods
*WeatherClient.GetMapUrl(layer, zoom, xCoord, yCoord)* Gets a string url of a given layer map.
- *layer* (Enums.MapLayer): The type of layer of the map.
- *zoom* (int): The zoom level of the map.
- *xCoord* (int): The x coordinate of the map.
- *yCoord* (int): The y coordinate of the map.
- *returns* (string): The url of the map.

*WeatherClient.DownloadMap(fileName, layer, zoom, xCoord, yCoord)* Gets a layer map and downloads it in a given location.
- *fileName* (string): The path of the new file.
- *layer* (Enums.MapLayer): The type of layer of the map.
- *zoom* (int): The zoom level of the map.
- *xCoord* (int): The x coordinate of the map.
- *yCoord* (int): The y coordinate of the map.

*WeatherClient.DownloadMapAsync(fileName, layer, zoom, xCoord, yCoord)* Gets a layer map and downloads it in a given location asynchronously.
- *fileName* (string): The path of the new file.
- *layer* (Enums.MapLayer): The type of layer of the map.
- *zoom* (int): The zoom level of the map.
- *xCoord* (int): The x coordinate of the map.
- *yCoord* (int): The y coordinate of the map.
- *returns* (Task): The task of downloading the file.

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)
