## Welcome to Weather.NET
Weather.NET is a .NET 6.0 library, that uses [OpenWeatherMap API](https://openweathermap.org/api) to give the weather of cities and locations.

- [Documentation](https://eloyespinosa.github.io/Weather.NET/docs/)
- [Tutorial](https://eloyespinosa.github.io/Weather.NET/tutorial)
- [Examples](https://eloyespinosa.github.io/Weather.NET/examples/)

### What's new in 1.2.0?
- Now the Air Pollution API is supported with the AirPollution class.
- The responses are given in a new model, Models.PollutionModel.PollutionModel.
- Now the Get...() methods in WeatherClient are in a static class called RestApi, and they are all now internal, not public.
- WeatherModel.Cod is now WeatherModel.StatusCode.
- GlobalUsings.cs is a new file of only global usings, for clearer code.

[Back](https://eloyespinosa.github.io)
