## WeatherResponse
This struct contains all of the useful information in a OpenWeatherMap API response.
### Properties
All of this properties can be publicly read, but only internally set, which means that only classes of the Weather.NET library can change the properties of a WeatherResponse.
- `CityName` (string): The name of the city analyzed.
- `CityId` (long): The OpenWeatherMap City ID of the city analyzed. More information in [the OpenWeatherMap docs](https://openweathermap.org/current#cityid).
- `LocationLongitude` (double): The longitude of the location analyzed.
- `LocationLatitude` (double): The latitude of the location analyzed.
- `Title` (string): A one-word description of the weather in english.
- `Description` (string): A short description of the weather in the language specified.
- `Temperature` (double): The temperature in the system of measurement specified.
- `AtmosphericPressure` (int): The atmospheric pressure of the city, in hPa.
- `HumidityPercentage` (int): The humidity (%) of the location.
- `WindSpeed` (double): The speed of the wind in the system of measurement specified.
- `WindDirection` (int): The direction of the wind in meteorological degrees.
- `CloudPercentage` (int): The cloud percentage of the location.

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)
