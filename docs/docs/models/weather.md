## WeatherModel
This serializable class contains the model of the API response of CurrentWeather and FutureWeather.
### Properties
- *Location* (object): Information about the location analyzed.
    - *Longitude* (double): The longitude of the location analyzed.
    - *Latitude* (double): The latitude of the location analyzed.
- *Weather* (object[]): Description of the weather.
    - *Id* (int): The OpenWeatherMap Weather ID.
    - *Title* (string): A small, one to two word description of the weather in english.
    - *Description* (string): A short description of the weather in [the language specified](https://eloyespinosa.github.io/Weather.NET/docs/enums/languages).
    - *IconId* (string): The OpenWeatherMap Icon ID of the weather.
    - *IconUrl* (string): The url of the OpenWeatherMap Weather Icon.
- *Base* (string): Internal parameter.
- *Main* (object): Useful information about the weather, like the temperature.
    - *Temperature* (double): The temperature of the location analyzed. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *TemperaturePerception* (double): The temperature of the location, accounting for the human perception of temperature. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *TemperatureMin* (double): The minimum temperature observed. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *TemperatureMax* (double): The maximum temperature observed. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *AtmosphericPressure* (int): The atmospheric pressure in hPa.
    - *HumidityPercentage* (int): The humidity (%) of the location.
- *Visibility* (int): Visibility in meters, the maximum value is 10km.
- *Wind* (object): Information about the wind.
    - *Speed* (double): The speed of the wind. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *Direction* (int): The direction of the wind in degrees.
    - *Gust* (double?): The wind gust. Can be null if not available.
- *Clouds* (object): Information about the clouds.
    - *Percentage* (int): The percentage of clouds in the location.
- *Rain* (object?): Information about the rain. Can be null if not available.
    - *PastHourVolume* (double?): Rain volume for the past hour.
    - *Past3HoursVolume* (double?): Rain volume for the last 3 hours.
- *Snow* (object?): Information about the snow. Can be null if not available.
    - *PastHourVolume* (double?): Snow volume for the past hour.
    - *Past3HoursVolume* (double?): Snow volume for the last 3 hours.
- *AnalysisDateUnix* (long): The exact moment of the analysis, in unix seconds, UTC.
- *AnalysisDate* (DateTime): The exact moment of the analysis, UTC.
- *Internal* (object): Internal parameters.
    - *Message* (double): Internal parameter.
    - *Country* (string): The ISO 3166 country code of the location.
    - *SunriseUnix* (long): The sunrise time in unix seconds, UTC.
    - *SunriseTime* (DateTime): The sunrise time, UTC.
    - *SunsetUnix* (long): The sunset time in unix seconds, UTC.
    - *SunsetTime* (DateTime): The sunset time, UTC.
- *Timezone* (int): Shift in seconds from UTC.
- *CityId* (long): The OpenWeatherMap City ID. More information in [the OpenWeatherMap docs](https://openweathermap.org/current#cityid).
- *CityName* (string): The name of the city analyzed.
- *StatusCode* (int): The HTTP request status code.

[Back](https://eloyespinosa.github.io/Weather.NET/docs/models/)
