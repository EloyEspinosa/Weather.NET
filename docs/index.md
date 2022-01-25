## Welcome to Weather.NET
Weather.NET is a .NET 6.0 library, that uses [OpenWeatherMap API](https://openweathermap.org/api) to give the weather of cities and locations.

- [Documentation](https://eloyespinosa.github.io/Weather.NET/docs/)
- [Tutorial](https://eloyespinosa.github.io/Weather.NET/tutorial)
- [Examples](https://eloyespinosa.github.io/Weather.NET/examples/)

### What's new in 1.3.0?
From 1.2.0:
    - Added support for the One Call API:
        - OneCallApi contains extensions for WeatherClient that support calls to the API.
        - Models.OneCallModel contains the model of the response of all One Call API calls.
        - Enums.ExcludeOneCall contains parameters in the One Call response that can be excluded.
        - RestApi now does not have synchronous methods.
    
From 1.3.0-rc.1:
    - Fixed a bug where Measurement and Language wouldn't work in historical One Call API calls.

[Back](https://eloyespinosa.github.io)
