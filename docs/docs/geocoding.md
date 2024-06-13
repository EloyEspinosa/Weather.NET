## GeoCoding
This class provides access to OpenWeatherMap's GeoCoding API (1.0), which lets users transform any location name into geographical coordinates, and the other way around (reverse geocoding).
### Methods
*WeatherClient.CoordinatesByLocationName(cityName, stateCode, countryCode, limit)*
Gets a list of [GeoCodingModel](https://eloyespinosa.github.io/Weather.NET/docs/models/geocoding) objects with the geographical coordinates of locations with the given name.
- *cityName* (string): The name of the city.
- *stateCode* (string): The state code (only for the US). Defaults to none.
- *countryCode* (string): The ISO 3166 country code. Defaults to none.
- *limit* (int): Number of locations in the API response (up to 5 results can be returned in the API response). Defaults to 5.
- *returns* (List\<GeoCodingModel\>): Up to 5 geographical coordinates that match the query.

*WeatherClient.CoordinatesByZipCode(zipCode, countryCode)*
Gets a [GeoCodingModel](https://eloyespinosa.github.io/Weather.NET/docs/models/geocoding) object with the geographical coordinates of the location with the given zip code.
- *zipCode* (string): The zip/postal code.
- *countryCode* (string): The ISO 3166 country code.
- *returns* (GeoCodingModel): The geographical coordinates of the location.

*WeatherClient.LocationNameByCoordinates(latitude, longitude, limit)*
Gets a list of [GeoCodingModel](https://eloyespinosa.github.io/Weather.NET/docs/models/geocoding) objects with the location names on a given place in the world.
- *latitude* (double): Latitude.
- *longitude* (double): Longitude.
- *limit* (int): Number of locations in the API response (several results can be returned in the API response). Defaults to no limit.
- *returns* (List\<GeoCodingModel\>): Names of the locations on the coordinates given.

*WeatherClient.CoordinatesByLocationNameAsync(cityName, stateCode, countryCode, limit)*
Gets a list of [GeoCodingModel](https://eloyespinosa.github.io/Weather.NET/docs/models/geocoding) objects with the geographical coordinates of locations with the given name asynchronously.
- *cityName* (string): The name of the city.
- *stateCode* (string): The state code (only for the US). Defaults to none.
- *countryCode* (string): The ISO 3166 country code. Defaults to none.
- *limit* (int): Number of locations in the API response (up to 5 results can be returned in the API response). Defaults to 5.
- *returns* (List\<GeoCodingModel\>): Up to 5 geographical coordinates that match the query.

*WeatherClient.CoordinatesByZipCodeAsync(zipCode, countryCode)*
Gets a [GeoCodingModel](https://eloyespinosa.github.io/Weather.NET/docs/models/geocoding) object with the geographical coordinates of the location with the given zip code asynchronously.
- *zipCode* (string): The zip/postal code.
- *countryCode* (string): The ISO 3166 country code.
- *returns* (GeoCodingModel): The geographical coordinates of the location.

*WeatherClient.LocationNameByCoordinatesAsync(latitude, longitude, limit)*
Gets a list of [GeoCodingModel](https://eloyespinosa.github.io/Weather.NET/docs/models/geocoding) objects with the location names on a given place in the world asynchronously.
- *latitude* (double): Latitude.
- *longitude* (double): Longitude.
- *limit* (int): Number of locations in the API response (several results can be returned in the API response). Defaults to no limit.
- *returns* (List\<GeoCodingModel\>): Names of the locations on the coordinates given.

[Back](https://eloyespinosa.github.io/Weather.NET/docs/)
