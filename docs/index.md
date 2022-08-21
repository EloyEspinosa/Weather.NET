## Welcome to Weather.NET
Weather.NET is a .NET 6.0 library, that uses [OpenWeatherMap API](https://openweathermap.org/api) to give the weather of cities and locations.

- [Documentation](https://eloyespinosa.github.io/Weather.NET/docs/)
- [Tutorial](https://eloyespinosa.github.io/Weather.NET/tutorial)
- [Examples](https://eloyespinosa.github.io/Weather.NET/examples/)

### What's new in 1.3.2?
- Fixed a bug (#2) where rain volume properties were set to integers, even though the value could a decimal number, so changed all of the rain volume properties from `int?` to `double?`.
- Also changed all of the snow volume properties from `int?` to `double?`.

[Back](https://eloyespinosa.github.io)
