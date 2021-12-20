## AirPollution
This class provides extension methods for WeatherClient that get the air pollution of a given location.
### Methods
*WeatherClient.GetCurrentAirPollution(latitude, longitude)*: Gets the current air pollution of a given location.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *returns* (PollutionModel): The API response, that contains information about the current air pollution.

*WeatherClient.GetForecastAirPollution(latitude, longitude)*: Gets a forecast of the air pollution of a given location.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *returns* (PollutionModel): The API response, that contains a list of forecasts of the air pollution.

*WeatherClient.GetHistoricalAirPollution(latitude, longitude, startUnix, endUnix)*: Gets a historical record of the air pollution of a given location.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *startUnix* (long): The start of the historical record, in Unix seconds.
- *endUnix* (long): The end of the historical record, in Unix seconds.
- *returns* (PollutionModel): The API response, that contains a historical record of the air pollution.

*WeatherClient.GetCurrentAirPollutionAsync(latitude, longitude)*: Gets the current air pollution of a given location asynchronously.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *returns* (PollutionModel): The API response, that contains information about the current air pollution.

*WeatherClient.GetForecastAirPollutionAsync(latitude, longitude)*: Gets a forecast of the air pollution of a given location asynchronously.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *returns* (PollutionModel): The API response, that contains a list of forecasts of the air pollution.

*WeatherClient.GetHistoricalAirPollutionAsync(latitude, longitude, startUnix, endUnix)*: Gets a historical record of the air pollution of a given location asynchronously.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *startUnix* (long): The start of the historical record, in Unix seconds.
- *endUnix* (long): The end of the historical record, in Unix seconds.
- *returns* (PollutionModel): The API response, that contains a historical record of the air pollution.

[Back](https://eloyespinosa.github.io/Weather.NET/docs/)