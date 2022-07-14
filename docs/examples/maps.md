## WeatherMap Example
This code example shows how to use the library to get a weather map.

```c#
using System;
using Weather.NET;
using Weather.NET.Enums;

namespace Weather.NET.Examples;

public static class WeatherMapExample
{
    // Use your API key here.
    public static WeatherClient Client = new WeatherClient("This is a api key that can be used. Believe me.");

    public static void TemperatureExample()
    {
        // Gets a temperature map of the entire world.
        Console.WriteLine(Client.GetWeatherMapUrl(MapLayer.Temperature, 0, 0, 0));
        Client.DownloadWeatherMap(MapLayer.Temperature, 0, 0, 0);

        // Gets a temperature map of a specific part of the world.
        WeatherMap.DownloadWeatherMap(Client, MapLayer.Temperature, 0, 0, 0);
    }

    public static async Task CloudsExample()
    {
        // Gets a cloud map of the entire world.
        Console.WriteLine(Client.GetWeatherMapUrl(MapLayer.Clouds, 0, 0, 0));
        await Client.DownloadWeatherMapAsync(MapLayer.Clouds, 0, 0, 0);

        // Gets a cloud map of a specific part of the world.
        WeatherMap.DownloadWeatherMapAsync(Client, MapLayer.Clouds, 1, 1, 1);
    }

    /*
    Other MapLayer options:
    - Rain
    - Pressure
    - WindSpeed
    - Snow
    */
}
```

[Back](https://eloyespinosa.github.io/Weather.NET/examples)