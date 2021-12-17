## WeatherMap
This class provides layer maps of the weather.
### Methods
```GetMapUrl(layer, zoom, xCoord, yCoord, apiKey)``` Gets a string url of a given layer map.
- `layer` (Enums.MapLayer): The type of layer of the map.
- `zoom` (int): The zoom level of the map.
- `xCoord` (int): The x coordinate of the map.
- `yCoord` (int): The y coordinate of the map.
- `apiKey` (string): The api key of the user.
- returns (string): The url of the map.

```DownloadMap(fileName, layer, zoom, xCoord, yCoord, apiKey)``` Gets a layer map and downloads it in a given location.
- `fileName` (string): The path of the new file.
- `layer` (Enums.MapLayer): The type of layer of the map.
- `zoom` (int): The zoom level of the map.
- `xCoord` (int): The x coordinate of the map.
- `yCoord` (int): The y coordinate of the map.
- `apiKey` (string): The api key of the user.

```DownloadMapAsync(fileName, layer, zoom, xCoord, yCoord, apiKey)``` Gets a layer map and downloads it in a given location asynchronously.
- `fileName` (string): The path of the new file.
- `layer` (Enums.MapLayer): The type of layer of the map.
- `zoom` (int): The zoom level of the map.
- `xCoord` (int): The x coordinate of the map.
- `yCoord` (int): The y coordinate of the map.
- `apiKey` (string): The api key of the user.
- returns (Task): The task of downloading the file.

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)
