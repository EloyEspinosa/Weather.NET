## FutureWeather
This class provides a weather forecast of a location for every 3 hours, until 5 days into the future.
### Methods
```New(cityName, apiKey, timestampCount, measurement, language)```
Gets a List of [WeatherResponses](https://eloyespinosa.github.io/Weather.NET/docs/models/response), each one with a DateTimeOffset that contains the time of the forecast.
- `cityName` (string): The name of the city.
- `apiKey` (string): The api key of the user.
- `timestampCount` (int): The amount of forecasts in the output, each one separated by 3 hours.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (List\<(DateTimeOffset, WeatherResponse)\>): The weather forecast of the city.

```New(cityId, apiKey, timestampCount, measurement, language)```
Gets a List of [WeatherResponses](https://eloyespinosa.github.io/Weather.NET/docs/models/response), each one with a DateTimeOffset that contains the time of the forecast.
- `cityId` (long): The OpenWeatherMap City ID of the city. More information in [the OpenWeatherMap docs.](https://openweathermap.org/current#cityid)
- `apiKey` (string): The api key of the user.
- `timestampCount` (int): The amount of forecasts in the output, each one separated by 3 hours.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (List\<(DateTimeOffset, WeatherResponse)\>): The weather forecast of the city.

```New(latitude, longitude, apiKey, timestampCount, measurement, language)```
Gets a List of [WeatherResponses](https://eloyespinosa.github.io/Weather.NET/docs/models/response), each one with a DateTimeOffset that contains the time of the forecast.
- `latitude` (double): The latitude of the location.
- `longitude` (double): The longitude of the location.
- `apiKey` (string): The api key of the user.
- `timestampCount` (int): The amount of forecasts in the output, each one separated by 3 hours.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (List\<(DateTimeOffset, WeatherResponse)\>): The weather forecast of the location.

```New(zipCode, countryCode, apiKey, timestampCount, measurement, language)```
Gets a List of [WeatherResponses](https://eloyespinosa.github.io/Weather.NET/docs/models/response), each one with a DateTimeOffset that contains the time of the forecast.
- `zipCode` (long): The location's ZIP Code. *Note: Try to use a more general ZIP code, because a lot of ZIP codes will not be available.*
- `countryCode` (string): The location's country [ISO 3166 code](https://www.iso.org/obp/ui/#search).
- `apiKey` (string): The api key of the user.
- `timestampCount` (int): The amount of forecasts in the output, each one separated by 3 hours.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (List\<(DateTimeOffset, WeatherResponse)\>): The weather forecast of the location.

```NewAsync(cityName, apiKey, timestampCount, measurement, language)```
Gets a List of [WeatherResponses](https://eloyespinosa.github.io/Weather.NET/docs/models/response) asynchronously, each one with a DateTimeOffset that contains the time of the forecast.
- `cityName` (string): The name of the city.
- `apiKey` (string): The api key of the user.
- `timestampCount` (int): The amount of forecasts in the output, each one separated by 3 hours.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (Task\<List\<(DateTimeOffset, WeatherResponse)\>\>): The weather forecast of the city.

```NewAsync(cityId, apiKey, timestampCount, measurement, language)```
Gets a List of [WeatherResponses](https://eloyespinosa.github.io/Weather.NET/docs/models/response) asynchronously, each one with a DateTimeOffset that contains the time of the forecast.
- `cityId` (long): The OpenWeatherMap City ID of the city. More information in [the OpenWeatherMap docs.](https://openweathermap.org/current#cityid)
- `apiKey` (string): The api key of the user.
- `timestampCount` (int): The amount of forecasts in the output, each one separated by 3 hours.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (Task\<List\<(DateTimeOffset, WeatherResponse)\>\>): The weather forecast of the city.

```NewAsync(latitude, longitude, apiKey, timestampCount, measurement, language)```
Gets a List of [WeatherResponses](https://eloyespinosa.github.io/Weather.NET/docs/models/response) asynchronously, each one with a DateTimeOffset that contains the time of the forecast.
- `latitude` (double): The latitude of the location.
- `longitude` (double): The longitude of the location.
- `apiKey` (string): The api key of the user.
- `timestampCount` (int): The amount of forecasts in the output, each one separated by 3 hours.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (Task\<List\<(DateTimeOffset, WeatherResponse)\>\>): The weather forecast of the location.

```NewAsync(zipCode, countryCode, apiKey, timestampCount, measurement, language)```
Gets a List of [WeatherResponses](https://eloyespinosa.github.io/Weather.NET/docs/models/response) asynchronously, each one with a DateTimeOffset that contains the time of the forecast.
- `zipCode` (long): The location's ZIP Code. *Note: Try to use a more general ZIP code, because a lot of ZIP codes will not be available.*
- `countryCode` (string): The location's country [ISO 3166 code](https://www.iso.org/obp/ui/#search).
- `apiKey` (string): The api key of the user.
- `timestampCount` (int): The amount of forecasts in the output, each one separated by 3 hours.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (Task\<List\<(DateTimeOffset, WeatherResponse)\>\>): The weather forecast of the location.

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)
