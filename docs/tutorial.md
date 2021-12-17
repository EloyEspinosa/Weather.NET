## How to Use
Before starting to use the package, make sure to have your own [OpenWeatherMap API key](https://openweathermap.org/appid#start) by [signing up.](https://home.openweathermap.org/users/sign_up)

### Adding the package.
To install the package, go to the [package in Nuget](https://nuget.org/packages/Weather.NET) and follow the instructions to add the package to your project.

After the package has been installed and referenced in your project, you can start using in your code with the following using statements:
- `using Weather.NET;`: This one is pretty obvious, this adds things like WeatherClient, CurrentWeather, FutureWeather and WeatherMap, which are required to use the package.
- `using Weather.NET.Enums;`: This one is optional, you will only use it if you want to use the maps feature, or want to change either the measurement system or the language of the output of an API call.
- `using Weather.NET.Models.WeatherModel;`: This one is only required if you want to use either the CurrentWeather or the FutureWeather features.

### Using the package.
To start using the package, just create a new `WeatherClient` object, using your API key as the only argument. This will give you access to the following methods:
- `GetCurrentWeather` and `GetCurrentWeatherAsync`: Gets the current weather of a location.
- `GetForecast` and `GetForecastAsync`: Gets a list of forecasts.
- `GetWeatherMapUrl`: Gets the url of a OpenWeatherMap 1.0 Weather Map.
- `DownloadWeatherMap` and `DownloadWeatherMapAsync`: Downloads a png of a OpenWeatherMap 1.0 Weather Map.

More information can be found in the [documentation](https://eloyespinosa.github.io/Weather.NET/docs).

You can also look at some code [examples](https://eloyespinosa.github.io/Weather.NET/examples).
<br>
<br>
<br>
[Back to main page.](https://eloyespinosa.github.io/Weather.NET)
