## How to Use
Before starting to use the package, make sure to have your own [OpenWeatherMap API key](https://openweathermap.org/appid#start) by [signing up.](https://home.openweathermap.org/users/sign_up)

### Adding the package.
To install the package, go to the [package in Nuget](https://nuget.org/packages/Weather.NET) and follow the instructions to add the package to your project.

After the package has been installed and referenced in your project, you can start using in your code with the following using statements:
- `using Weather.NET;`: This one is pretty obvious, this adds things like OneCallAPI, WeatherClient, CurrentWeather, FutureWeather, AirPollution and WeatherMap, which are required to use the package.
- `using Weather.NET.Enums;`: This one is optional, you will only use it if you want to use the One Call API, the maps feature, or want to change either the measurement system or the language of the output of an API call.
- `using Weather.NET.Models.WeatherModel;`: This one is only required if you want to use either the CurrentWeather or the FutureWeather features.
- `using Weather.NET.Models.OneCallModel;`: This one is only required if you want to use the One Call API.
- `using Weather.NET.Models.PollutionModel;`: This one is only required if you want to use the AirPollution feature.

### Using the package.
To start using the package, just create a new `WeatherClient` object, using your API key as the only argument. This will give you access to the following methods:
- `GetCurrentWeather` and `GetCurrentWeatherAsync`: Gets the current weather of a location.
- `GetForecast` and `GetForecastAsync`: Gets a list of forecasts.
- `GetCurrentAirPollution` and `GetCurrentAirPollutionAsync`: Gets a current description of the air pollution of a location.
- `GetForecastAirPollution` and `GetForecastAirPollutionAsync`: Gets a forecast of the air pollution of a location.
- `GetHistoricalAirPollution` and `GetHistoricalAirPollutionAsync`: Gets a historical record of the air pollution of a location.
- `GetOneCall` and `GetOneCallAsync`: Gets, with one call, the current weather, a minutely forecast for the next minute, a hourly forecast for the next two days, a daily forecast for the next week, and national weather alerts of a location.
- `GetHistoricalOneCall` and `GetHistoricalOneCallAsync`: Gets a historical One Call API response, for a certain day, for a given location.
- `GetWeatherMapUrl`: Gets the url of a OpenWeatherMap 1.0 Weather Map.
- `DownloadWeatherMap` and `DownloadWeatherMapAsync`: Downloads an OpenWeatherMap 1.0 Weather Map.
- `GetStreetMapUrl`: Gets the url of a OpenStreetMap Base Map
- `DownloadStreetMap`and `DownloadStreetMapAsync`: Downloads a OpenStreetMap Base Map.
And you will also be able to use the GeoCoding API, with the following methods:
- `CoordinatesByLocationName`and `CoordinatesByLocationNameAsync`: Gets the geographical coordinates of a location using it's name.
- `CoordinatesByZipCode` and `CoordinatesByZipCodeAsync`: Converts a location's zip code into its geographical coordinates.
- `LocationNameByCoordinates` and `LocationNameByCoordinatesAsync`: Gets all locations that match given geographical coordinates.

More information can be found in the [documentation](https://eloyespinosa.github.io/Weather.NET/docs).

You can also look at some code [examples](https://eloyespinosa.github.io/Weather.NET/examples).
<br>
<br>
<br>
[Back](https://eloyespinosa.github.io/Weather.NET)
