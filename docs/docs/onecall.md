## OneCallApi
This class provides extension methods for WeatherClient that get [OpenWeather's One Call API](https://openweathermap.org/api/one-call-api).

### Methods
*WeatherClient.GetOneCall(latitude, longitude, exclude, measurement, language)*
Gets a new [OneCallModel](https://eloyespinosa.github.io/Weather.NET/docs/models/onecall) object with the One Call API response of a given location.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *exclude* (Enums.ExcludeOneCall[]): The parameters to exclude in the response.
- *measurement* (Enums.Measurement): The measurement system of the output.
- *language* (Enums.Language): The language of the output.
- *returns* (OneCallModel): The API response, containing the parameters, which depending on the call, might be null.

*WeatherClient.GetHistoricalOneCall(latitude, longitude, dateUnix, measurement, language)*
Gets a new [OneCallModel](https://eloyespinosa.github.io/Weather.NET/docs/models/onecall) object that acts as a "time machine", that goes up to 5 days back in time, for a One Call response of the date given, where MinutelyForecasts, DailyForecasts and NationalAlerts were excluded, CurrentWeather refers to the exact date given, and HourlyForecasts refers to a description of the weather of a specific hour in the day.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *dateUnix* (long): The exact moment of the analysis in unix seconds, UTC.
- *measurement* (Enums.Measurement): The measurement of the output.
- *language* (Enums.Language): The language of the output.
- *returns* (OneCallModel): The API response, containing the paramters, which depending on the call, might be null.

*WeatherClient.GetOneCallAsync(latitude, longitude, exclude, measurement, language)*
Gets a new [OneCallModel](https://eloyespinosa.github.io/Weather.NET/docs/models/onecall) object with the One Call API response of a given location asynchronously.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *exclude* (Enums.ExcludeOneCall[]): The parameters to exclude in the response.
- *measurement* (Enums.Measurement): The measurement system of the output.
- *language* (Enums.Language): The language of the output.
- *returns* (OneCallModel): The API response, containing the parameters, which depending on the call, might be null.

*WeatherClient.GetHistoricalOneCallAsync(latitude, longitude, dateUnix, measurement, language)*
Gets a new [OneCallModel](https://eloyespinosa.github.io/Weather.NET/docs/models/onecall) object that acts as a "time machine", that goes up to 5 days back in time, for a One Call response of the date given, where MinutelyForecasts, DailyForecasts and NationalAlerts were excluded, CurrentWeather refers to the exact date given, and HourlyForecasts refers to a description of the weather of a specific hour in the day asynchronously.
- *latitude* (double): The latitude of the location.
- *longitude* (double): The longitude of the location.
- *dateUnix* (long): The exact moment of the analysis in unix seconds, UTC.
- *measurement* (Enums.Measurement): The measurement of the output.
- *language* (Enums.Language): The language of the output.
- *returns* (OneCallModel): The API response, containing the paramters, which depending on the call, might be null.

[Back](https://eloyespinosa.github.io/Weather.NET/docs/)