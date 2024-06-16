## Welcome to Weather.NET
Weather.NET is a .NET 8 library, that uses [OpenWeatherMap API](https://openweathermap.org/api) to give the weather of cities and locations.

- [Documentation](https://eloyespinosa.github.io/Weather.NET/docs/)
- [Tutorial](https://eloyespinosa.github.io/Weather.NET/tutorial)

### What's new in 1.3.3?
- Updated to the latest LTS .NET version, .NET 8.

### What's new in 1.4.0-beta.1?
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

[Back](https://eloyespinosa.github.io)
