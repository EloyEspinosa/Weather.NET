## WeatherModel
This serializable class contains the model of the API response of CurrentWeather and FutureWeather.
### Properties
- *Location* (object): Information about the location analyzed.
    - *Longitude* (double): The longitude of the location analyzed.
    - *Latitude* (double): The latitude of the location analyzed.
- *Weather[0]* (object): Description of the weather.
    - *Id* (int): The OpenWeatherMap Weather ID.
    - *Title* (string): A small, one to two word description of the weather in english.
    - *Description* (string): A short description of the weather in [the language specified](https://eloyespinosa.github.io/Weather.NET/docs/enums/languages).
    - *IconId* (string): The OpenWeatherMap Icon ID of the weather.
    - *IconUrl* (string): The url of the OpenWeatherMap Weather Icon.
- *Main* (object): Useful information about the weather, like the temperature.
    - *Temperature* (double): The temperature of the location analyzed. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *TemperaturePerception* (double): The temperature of the location, accounting for the human perception of temperature. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *TemperatureMin* (double): The minimum temperature observed. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *TemperatureMax* (double): The maximum temperature observed. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *AtmosphericPressure* (int): The atmospheric pressure in hPa.
    - *HumidityPercentage* (int): The humidity (%) of the location.
- *Visibility* (int): Internal parameter.
- *Wind* (object): Information about the wind.
    - *Speed* (double): The speed of the wind. Depends on the [measurement system](https://eloyespinosa.github.io/Weather.NET/docs/enums/measurements).
    - *Direction* (int): The direction of the wind in degrees.
- *Clouds* (object): Information about the clouds.
    - *Percentage* (int): The percentage of clouds in the location.
- *AnalysisDate* (long): The exact moment of the analysis, in unix seconds.
- *Internal* (object): Internal parameters.
    - *Message* (double): Internal parameter.
    - *Country* (string): The ISO 3166 country code of the location.
    - *SunriseUnix* (long): The sunrise time in unix seconds.
    - *SunsetUnix* (long): The sunset time in unix seconds.
- *Timezone* (int): Shift in seconds from UTC.
- *CityId* (long): The OpenWeatherMap City ID. More information in [the OpenWeatherMap docs](https://openweathermap.org/current#cityid).
- *CityName* (string): The name of the city analyzed.
- *Cod* (int): The HTTP request status code. Internal parameter.

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)
