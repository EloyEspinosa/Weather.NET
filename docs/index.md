## Welcome to Weather.NET
Weather.NET is a .NET 6.0 library, that uses [OpenWeatherMap API](https://openweathermap.org/api) to give the weather of cities and locations.

- [Documentation](https://eloyespinosa.github.io/Weather.NET/docs/)
- [Tutorial](https://eloyespinosa.github.io/Weather.NET/tutorial)
- [Examples](https://eloyespinosa.github.io/Weather.NET/examples/)

### What's new in 1.3.1?
- Changed the dates from unix seconds to DateTime objects, and the old dates are now moved to a separate property. Example: Models.WeatherModel.AnalysisDate is moved to Models.WeatherModel.AnalysisDateUnix and Models.WeatherModel.AnalysisDate now contains a DateTime object.
- Removed dates in unix seconds that accounted for timezones, instead of that, use the new DateTime objects with the timezone offset added. Ex: `Models.WeatherModel.AnalysisDate.AddSeconds(Models.WeatherModel.Timezone)`.
- Added missing nullable properties like the wind gust, rain information and snow information.

[Back](https://eloyespinosa.github.io)
