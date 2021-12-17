## CurrentWeather
This class provides the current weather of a given location.
### Methods
```New(cityName, apiKey, measurement, language)```
Gets a new [WeatherResponse](https://eloyespinosa.github.io/Weather.NET/docs/models/response) object with the current weather of a specific city.
- `cityName` (string): The name of the city.
- `apiKey` (string): The api key of the user.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (WeatherResponse): The current weather of the city.

```New(cityId, apiKey, measurement, language)```
Gets a new [WeatherResponse](https://eloyespinosa.github.io/Weather.NET/docs/models/response) object with the current weather of a specific city.
- `cityId` (long): The OpenWeatherMap City ID of the city. More information in [the OpenWeatherMap docs.](https://openweathermap.org/current#cityid)
- `apiKey` (string): The api key of the user.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (WeatherResponse): The current weather of the city.

```New(latitude, longitude, apiKey, measurement, language)```
Gets a new [WeatherResponse](https://eloyespinosa.github.io/Weather.NET/docs/models/response) object with the current weather of a given location.
- `latitude` (double): The latitude of the location.
- `longitude` (double): The longitude of the location.
- `apiKey` (string): The api key of the user.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (WeatherResponse): The current weather of the city.

```New(zipCode, countryCode, apiKey, measurement, language)```
Gets a new [WeatherResponse](https://eloyespinosa.github.io/Weather.NET/docs/models/response) object with the current weather of a given location.
- `zipCode` (long): The location's ZIP Code. *Note: Try to use a more general ZIP code, because a lot of ZIP codes will not be available.*
- `countryCode` (string): The location's country [ISO 3166 code](https://www.iso.org/obp/ui/#search).
- `apiKey` (string): The api key of the user.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (WeatherResponse): The current weather of the city.

```NewAsync(cityName, apiKey, measurement, language)```
Gets a new [WeatherResponse](https://eloyespinosa.github.io/Weather.NET/docs/models/response) object with the current weather of a specific city asynchronously.
- `cityName` (string): The name of the city.
- `apiKey` (string): The api key of the user.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (Task\<WeatherResponse\>): The current weather of the city.

```NewAsync(cityId, apiKey, measurement, language)```
Gets a new [WeatherResponse](https://eloyespinosa.github.io/Weather.NET/docs/models/response) object with the current weather of a specific city asynchronously.
- `cityId` (long): The OpenWeatherMap City ID of the city. More information in [the OpenWeatherMap docs.](https://openweathermap.org/current#cityid)
- `apiKey` (string): The api key of the user.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (Task\<WeatherResponse\>): The current weather of the city.

```NewAsync(latitude, longitude, apiKey, measurement, language)```
Gets a new [WeatherResponse](https://eloyespinosa.github.io/Weather.NET/docs/models/response) object with the current weather of a given location asynchronously.
- `latitude` (double): The latitude of the location.
- `longitude` (double): The longitude of the location.
- `apiKey` (string): The api key of the user.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (Task\<WeatherResponse\>): The current weather of the city.

```NewAsync(zipCode, countryCode, apiKey, measurement, language)```
Gets a new [WeatherResponse](https://eloyespinosa.github.io/Weather.NET/docs/models/response) object with the current weather of a given location asynchronously.
- `zipCode` (long): The location's ZIP Code. *Note: Try to use a more general ZIP code, because a lot of ZIP codes will not be available.*
- `countryCode` (string): The location's country [ISO 3166 code](https://www.iso.org/obp/ui/#search).
- `apiKey` (string): The api key of the user.
- `measurement` (Enums.Measurement): The system of measurement that the output uses. Defaults to Measurement.Standard.
- `language` (Enums.Language): The language of the output. Defaults to Language.English.
- returns (Task\<WeatherResponse\>): The current weather of the city.

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)
