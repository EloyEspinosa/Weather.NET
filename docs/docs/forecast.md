## FutureWeather
This class provides extension methods for WeatherClient that get a list of weather forecasts of a location for every 3 hours, until 5 days into the future.
### Methods
*WeatherClient.GetForecast(cityName, timestampCount, measurement, language)*
Gets a List of [WeatherModels](https://eloyespinosa.github.io/Weather.NET/docs/models/weather).
- *cityName* (string): The name of the city.
- *timestampCount* (int): The amount of forecasts in the output, each one separated by 3 hours.
- *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- *language* (Enums.Language): The language of the output. Defaults to Language.English.
- *returns* (List\<WeatherModel\>): The weather forecast of the city.

*WeatherClient.GetForecast(cityId, timestampCount, measurement, language)*
Gets a List of [WeatherModels](https://eloyespinosa.github.io/Weather.NET/docs/models/weather).
- *cityId* (long): The OpenWeatherMap City ID of the city. More information in [the OpenWeatherMap docs.](https://openweathermap.org/current#cityid)
- *timestampCount* (int): The amount of forecasts in the output, each one separated by 3 hours.
- *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- *language* (Enums.Language): The language of the output. Defaults to Language.English.
- *returns* (List\<WeatherModel\>): The weather forecast of the city.

*WeatherClient.GetForecast(latitude, longitude, timestampCount, measurement, language)*
Gets a List of [WeatherModels](https://eloyespinosa.github.io/Weather.NET/docs/models/weather).
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *timestampCount* (int): The amount of forecasts in the output, each one separated by 3 hours.
- *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- *language* (Enums.Language): The language of the output. Defaults to Language.English.
- *returns* (List\<WeatherModel\>): The weather forecast of the location.

*WeatherClient.GetForecast(zipCode, countryCode, timestampCount, measurement, language)*
Gets a List of [WeatherModels](https://eloyespinosa.github.io/Weather.NET/docs/models/weather).
- *zipCode* (string): The location's ZIP Code. *Note: Try to use a more general ZIP code, because a lot of ZIP codes will not be available.*
- *countryCode* (string): The location's country [ISO 3166 code](https://www.iso.org/obp/ui/#search).
- *timestampCount* (int): The amount of forecasts in the output, each one separated by 3 hours.
- *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- *language* (Enums.Language): The language of the output. Defaults to Language.English.
- *returns* (List\<WeatherModel\>): The weather forecast of the location.

*WeatherClient.GetForecastAsync(cityName, timestampCount, measurement, language)*
Gets a List of [WeatherModels](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) asynchronously.
- *cityName* (string): The name of the city.
- *timestampCount* (int): The amount of forecasts in the output, each one separated by 3 hours.
- *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- *language* (Enums.Language): The language of the output. Defaults to Language.English.
- *returns* (List\<WeatherModel\>): The weather forecast of the city.

*WeatherClient.GetForecastAsync(cityId, timestampCount, measurement, language)*
Gets a List of [WeatherModels](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) asynchronously.
- *cityId* (long): The OpenWeatherMap City ID of the city. More information in [the OpenWeatherMap docs.](https://openweathermap.org/current#cityid)
- *timestampCount* (int): The amount of forecasts in the output, each one separated by 3 hours.
- *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- *language* (Enums.Language): The language of the output. Defaults to Language.English.
- *returns* (List\<WeatherModel\>): The weather forecast of the city.

*WeatherClient.GetForecastAsync(latitude, longitude, timestampCount, measurement, language)*
Gets a List of [WeatherModels](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) asynchronously.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *timestampCount* (int): The amount of forecasts in the output, each one separated by 3 hours.
- *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- *language* (Enums.Language): The language of the output. Defaults to Language.English.
- *returns* (List\<WeatherModel\>): The weather forecast of the location.

*WeatherClient.GetForecastAsync(zipCode, countryCode, timestampCount, measurement, language)*
Gets a List of [WeatherModels](https://eloyespinosa.github.io/Weather.NET/docs/models/weather) asynchronously.
- *zipCode* (string): The location's ZIP Code. *Note: Try to use a more general ZIP code, because a lot of ZIP codes will not be available.*
- *countryCode* (string): The location's country [ISO 3166 code](https://www.iso.org/obp/ui/#search).
- *timestampCount* (int): The amount of forecasts in the output, each one separated by 3 hours.
- *measurement* (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- *language* (Enums.Language): The language of the output. Defaults to Language.English.
- *returns* (List\<WeatherModel\>): The weather forecast of the location.

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)
