## CurrentWeather
This class provides extensions for the WeatherClient class, that get the current weather of a given location.
### Methods
- *WeatherClient.GetCurrentWeather(cityName, measurement, language)*
Gets a new [WeatherModel](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) object with the current weather of a specific city.
    - *cityName* (string): The name of the city.
    - *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
    - *language* (Enums.Language): The language of the output. Defaults to Language.English.
    - *returns* (WeatherModel): The current weather of the city.

- *WeatherClient.GetCurrentWeather(cityId, measurement, language)*
Gets a new [WeatherModel](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) object with the current weather of a specific city.
    - *cityId* (long): The OpenWeatherMap City ID of the city. More information in [the OpenWeatherMap docs.](https://openweathermap.org/current#cityid)
    - *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
    - *language* (Enums.Language): The language of the output. Defaults to Language.English.
    - *returns* (WeatherModel): The current weather of the city.

- *WeatherClient.GetCurrentWeather(latitude, longitude, measurement, language)*
Gets a new [WeatherModel](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) object with the current weather of a given location.
    - *latitude* (double): The latitude of the location.
    - *longitude* (double): The longitude of the location.
    - *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
    - *language* (Enums.Language): The language of the output. Defaults to Language.English.
    - *returns* (WeatherModel): The current weather of the city.

- *WeatherClient.GetCurrentWeather(zipCode, countryCode, measurement, language)*
Gets a new [WeatherModel](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) object with the current weather of a given location.
    - *zipCode* (string): The location's ZIP Code. *Note: Try to use a more general ZIP code, because a lot of ZIP codes will not be available.*
    - *countryCode* (string): The location's country [ISO 3166 code](https://www.iso.org/obp/ui/#search).
    - *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
    - *language* (Enums.Language): The language of the output. Defaults to Language.English.
    - *returns* (WeatherModel): The current weather of the city.

- *WeatherClient.GetCurrentWeatherAsync(cityName, measurement, language)*
Gets a new [WeatherModel](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) object with the current weather of a specific city asynchronously.
    - *cityName* (string): The name of the city.
    - *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
    - *language* (Enums.Language): The language of the output. Defaults to Language.English.
    - *returns* (WeatherModel): The current weather of the city.

- *WeatherClient.GetCurrentWeatherAsync(cityId, measurement, language)*
Gets a new [WeatherModel](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) object with the current weather of a specific city asynchronously.
    - *cityId* (long): The OpenWeatherMap City ID of the city. More information in [the OpenWeatherMap docs.](https://openweathermap.org/current#cityid)
    - *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
    - *language* (Enums.Language): The language of the output. Defaults to Language.English.
    - *returns* (WeatherModel): The current weather of the city.

- *WeatherClient.GetCurrentWeatherAsync(latitude, longitude, measurement, language)*
Gets a new [WeatherModel](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) object with the current weather of a given location asynchronously.
    - *latitude* (double): The latitude of the location.
    - *longitude* (double): The longitude of the location.
    - *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
    - *language* (Enums.Language): The language of the output. Defaults to Language.English.
    - *returns* (WeatherModel): The current weather of the city.

- *WeatherClient.GetCurrentWeatherAsync(zipCode, countryCode, measurement, language)*
Gets a new [WeatherModel](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) object with the current weather of a given location asynchronously.
    - *zipCode* (string): The location's ZIP Code. *Note: Try to use a more general ZIP code, because a lot of ZIP codes will not be available.*
    - *countryCode* (string): The location's country [ISO 3166 code](https://www.iso.org/obp/ui/#search).
    - *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
    - *language* (Enums.Language): The language of the output. Defaults to Language.English.
    - *returns* (WeatherModel): The current weather of the city.

[Back](https://eloyespinosa.github.io/Weather.NET/docs/)
