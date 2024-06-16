[![NuGet Package](https://img.shields.io/nuget/v/Weather.NET.svg?logo=nuget)](https://www.nuget.org/packages/Weather.NET)
[![Build Status](https://github.com/EloyEspinosa/Weather.NET/actions/workflows/integrate.yml/badge.svg)](https://github.com/EloyEspinosa/Weather.NET/actions)

# Weather.NET
A simple .NET library that uses OpenWeatherMap API to get the weather of different places and cities. Supports both synchronous and asynchronous methods.

- [Nuget Package](https://www.nuget.org/packages/Weather.NET)
- [Repository](https://github.com/EloyEspinosa/Weather.NET)
- [How to Contribute](https://github.com/EloyEspinosa/Weather.NET/blob/main/CONTRIBUTING.md)
- [Code of Conduct](https://github.com/EloyEspinosa/Weather.NET/blob/main/CODE_OF_CONDUCT.md)
- [License](https://github.com/EloyEspinosa/Weather.NET/blob/main/LICENSE)
- [Official Page](https://eloyespinosa.github.io/Weather.NET/)
- [Documentation](https://eloyespinosa.github.io/Weather.NET/docs/)
- [Tutorial](https://eloyespinosa.github.io/Weather.NET/tutorial)

## Features
- [One Call API](https://eloyespinosa.github.io/Weather.NET/docs/onecall)
- [Current weather](https://eloyespinosa.github.io/Weather.NET/docs/current)
- [Weather forecast](https://eloyespinosa.github.io/Weather.NET/docs/forecast)
- [Weather and street maps](https://eloyespinosa.github.io/Weather.NET/docs/maps)
- [Air pollution](https://eloyespinosa.github.io/Weather.NET/docs/pollution)
- [GeoCoding](https://eloyespinosa.github.io/Weather.NET/docs/geocoding)

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

// Gets OpenWeather's One Call API response of New Delhi.
OneCallModel currentOneCall = client.GetOneCall(28.6128, 77.2311, new ExcludeOneCall[]{ExcludeOneCall.Alerts}, Measurement.Metric, Language.Hindi);

// Gets a historical One Call API response of Ottawa.
OneCallModel historicalOneCall = await client.GetHistoricalOneCallAsync(45.4112, -75.6981, 1640900049, Measurement.Metric, Language.English);
...
```

## Latest Version: 1.3.3
- Updated to the latest LTS .NET version, .NET 8.

# Beta Version: 1.4.0-beta.1
Added support for OpenWeather's GeoCoding API, including a new model and the methods:
- CoordinatesByLocationName and CoordinatesByLocationNameAsync
- CoordinatesByZipCode and CoordinatesByZipCodeAsync
- LocationNameByCoordinates and LocationNameByCoordinatesAsync

Reworked WeatherMap class:
- Renamed class, from WeatherMap to Maps
- Added support for OpenStreetMap's Base Street Map (methods GetStreetMapUrl and DownloadStreetMap)
- Clarified parameter usage (tile coordinates vs. geographical coordinates)
- Added conversion from geographical to tile coordinates (function LatLongToTileCoordinates)

Fixed deadlock issue on synchronous calls to async methods.