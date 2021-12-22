[![NuGet Package](https://img.shields.io/nuget/v/Weather.NET.svg?logo=nuget&logoColor=white&&style=for-the-badge&colorB=green)](https://www.nuget.org/packages/Weather.NET)

# Weather.NET
A simple .NET library that uses OpenWeatherMap API to get the weather of different places and cities. Supports both synchronous and asynchronous methods.

- [Nuget Package](https://www.nuget.org/packages/Weather.NET)
- [Repository](https://github.com/EloyEspinosa/Weather.NET)
- [Official Page](https://eloyespinosa.github.io/Weather.NET/)
- [Documentation](https://eloyespinosa.github.io/Weather.NET/docs/)
- [Tutorial](https://eloyespinosa.github.io/Weather.NET/tutorial)
- [Examples](https://eloyespinosa.github.io/Weather.NET/examples/)

## Features
- [Current weather](https://eloyespinosa.github.io/Weather.NET/docs/current)
- [Weather forecast](https://eloyespinosa.github.io/Weather.NET/docs/forecast)
- [Weather maps](https://eloyespinosa.github.io/Weather.NET/docs/maps)
- [Air pollution](https://eloyespinosa.github.io/Weather.NET/docs/pollution)

## Example
```c#
using System;
using Weather.NET;
using Weather.NET.Enums;
using Weather.NET.Models.WeatherModel;
using Weather.NET.Models.PollutionModel;

...

WeatherClient client = new WeatherClient("Your API key");

// Gets a forecast of the London weather asynchronously, using the city name.
List<WeatherModel> forecasts = await client.GetForecastAsync("London", 8, Measurement.Metric, Language.Spanish);
Console.WriteLine(forecasts[7].Weather[0].Description);

// Gets the current temperature of New York synchronously, using the ZIP Code.
WeatherModel currentWeather = client.GetCurrentWeather("10001", "US", measurement: Measurement.Imperial);
Console.WriteLine(currentWeather.Main.Temperature);

// Gets maps of the entire world.
client.DownloadWeatherMap("temperatureMap.png", MapLayer.Temperature, 0, 0, 0);
await client.DownloadWeatherMapAsync("pressureMap.png", MapLayer.Pressure, 0, 0, 0);

// Gets the air pollution of Melbourne synchronously, using geo coordinates.
PollutionModel currentPollution = client.GetCurrentAirPollution(-37.814, 144.9633);

// Gets a forecast of the air pollution of Berlin asynchronously, using geo coordinates.
PollutionModel futurePollution = await client.GetForecastAirPollutionAsync(52.5244, 13.4105);

// Gets the history of the air pollution of Buenos Aires asynchronously, using geo coordinates and unix timestamps.
PollutionModel historicalPollution = await client.GetHistoricalAirPollutionAsync(-34.6132, -58.3772);
...
```

## Version 1.2.1
- New properties in Models.WeatherModel that now account for timezones for you.
