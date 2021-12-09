[![NuGet Package](https://img.shields.io/nuget/v/Weather.NET.svg?logo=nuget&logoColor=white&&style=for-the-badge&colorB=green)](https://www.nuget.org/packages/Weather.NET)

# Weather.NET
A simple .NET library that uses OpenWeatherMap API to get the weather of different places and cities.

- [Nuget Package](https://www.nuget.org/packages/Weather.NET)
- [Repository](https://github.com/EloyEspinosa/Weather.NET)
- [Official Page](https://eloyespinosa.github.io/Weather.NET/)
- [Documentation](https://eloyespinosa.github.io/Weather.NET/docs)

## Version 1.0.0
- The package is now no longer in alpha and beta, and now the versions from here will be long-time support.
- Now the library actually handles exceptions correctly with Weather.NET.Exceptions.
- The files have been reordered:
    - WeatherResponse is now Models.WeatherResponse.
    - WeatherLanguage is now Enums.Language and it is now a enum instead of a class with constants.
    - WeatherMeasurement is now Enums.Measurement and it is now a enum instead of a class with constants.
    - MapLayer is now Enums.MapLayer and it is now a enum instead of class with constants.