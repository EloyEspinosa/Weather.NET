namespace Weather.NET.Models.WeatherModel;

/// <summary>
/// Information about the location analyzed.
/// </summary>
public class Location
{
    /// <summary>
    /// The longitude of the location analyzed.
    /// </summary>
    [JsonProperty("lon")]
    public double Longitude { get; set; }

    /// <summary>
    /// The latitude of the location analyzed.
    /// </summary>
    [JsonProperty("lat")]
    public double Latitude { get; set; }
}

/// <summary>
/// Description of the weather.
/// </summary>
public class Weather
{
    /// <summary>
    /// The OpenWeatherMap Weather ID.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// A small description of the weather in english.
    /// </summary>
    [JsonProperty("main")]
    public string Title { get; set; }

    /// <summary>
    /// A short description of the weather in the language specified.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }

    /// <summary>
    /// The OpenWeatherMap Icon ID. Can be concatenated as " https://openweathermap.org/img/w/ " + IconId + ".png".
    /// </summary>
    [JsonProperty("icon")]
    public string IconId { get; set; }

    /// <summary>
    /// The url of the weather icon.
    /// </summary>
    public string IconUrl { get { return $"https://openweathermap.org/img/w/{IconId}.png"; } }
}

/// <summary>
/// Useful information about the weather, like temperature.
/// </summary>
public class Main
{
    /// <summary>
    /// The temperature of the location analyzed.
    /// </summary>
    [JsonProperty("temp")]
    public double Temperature { get; set; }

    /// <summary>
    /// The temperature of the location, accounting for the human perception of the weather.
    /// </summary>
    [JsonProperty("feels_like")]
    public double TemperaturePerception { get; set; }

    /// <summary>
    /// The minimum temperature observed.
    /// </summary>
    [JsonProperty("temp_min")]
    public double TemperatureMin { get; set; }

    /// <summary>
    /// The maximum temperature observed.
    /// </summary>
    [JsonProperty("temp_max")]
    public double TemperatureMax { get; set; }

    /// <summary>
    /// The atmospheric pressure in hPa.
    /// </summary>
    [JsonProperty("pressure")]
    public int AtmosphericPressure { get; set; }

    /// <summary>
    /// The humidity percentage of the location.
    /// </summary>
    [JsonProperty("humidity")]
    public int HumidityPercentage { get; set; }
}

/// <summary>
/// Information about the wind.
/// </summary>
public class Wind
{
    /// <summary>
    /// The speed of the wind.
    /// </summary>
    [JsonProperty("speed")]
    public double Speed { get; set; }

    /// <summary>
    /// The direction of the wind in degrees.
    /// </summary>
    [JsonProperty("deg")]
    public int Direction { get; set; }

    /// <summary>
    /// Wind gust. Can be null if not available.
    /// </summary>
    [JsonProperty("gust")]
    public double? Gust { get; set; }
}

/// <summary>
/// Information about the clouds.
/// </summary>
public class Clouds
{
    /// <summary>
    /// The percentage of clouds.
    /// </summary>
    [JsonProperty("all")]
    public int Percentage { get; set; }
}

/// <summary>
/// Information about the rain.
/// </summary>
public class Rain
{
    /// <summary>
    /// Rain volume for the past hour in mm.
    /// </summary>
    [JsonProperty("1h")]
    public int? PastHourVolume { get; set; }

    /// <summary>
    /// Rain volume for the last 3 hours in mm.
    /// </summary>
    [JsonProperty("3h")]
    public int? Past3HoursVolume { get; set; }
}

/// <summary>
/// Information about the snow.
/// </summary>
public class Snow
{
    /// <summary>
    /// Snow volume for the past hour in mm.
    /// </summary>
    [JsonProperty("1h")]
    public int? PastHourVolume { get; set; }

    /// <summary>
    /// Snow volume for the last 3 hours in mm.
    /// </summary>
    [JsonProperty("3h")]
    public int? Past3HoursVolume { get; set; }
}

/// <summary>
/// Internal parameters.
/// </summary>
public class Internal
{
    /// <summary>
    /// Internal parameter.
    /// </summary>
    [JsonProperty("message")]
    public double Message { get; set; }

    /// <summary>
    /// The ISO 3166 country code of the location.
    /// </summary>
    [JsonProperty("country")]
    public string Country { get; set; }

    /// <summary>
    /// The sunrise time in unix seconds, UTC.
    /// </summary>
    [JsonProperty("sunrise")]
    public long SunriseUnix { get; set; }

    /// <summary>
    /// The sunrise time, UTC.
    /// </summary>
    public DateTime SunriseTime
    {
        get { return DateTimeOffset.FromUnixTimeSeconds(SunriseUnix).UtcDateTime; }
    }

    /// <summary>
    /// The sunset time in unix seconds, UTC.
    /// </summary>
    [JsonProperty("sunset")]
    public long SunsetUnix { get; set; }

    /// <summary>
    /// The sunset time, UTC.
    /// </summary>
    public DateTime SunsetTime
    {
        get { return DateTimeOffset.FromUnixTimeSeconds(SunsetUnix).UtcDateTime; }
    }
}

/// <summary>
/// Contains all parameters in a API response. Supports current weather and forecasts.
/// </summary>
public class WeatherModel
{
    /// <summary>
    /// Information about the location analyzed.
    /// </summary>
    [JsonProperty("coord")]
    public Location Location { get; set; }

    /// <summary>
    /// Description of the weather.
    /// </summary>
    [JsonProperty("weather")]
    public List<Weather> Weather { get; set; }

    /// <summary>
    /// Internal parameter.
    /// </summary>
    [JsonProperty("base")]
    public string Base { get; set; }

    /// <summary>
    /// Useful information about the weather, like temperature.
    /// </summary>
    [JsonProperty("main")]
    public Main Main { get; set; }

    /// <summary>
    /// Visibility in meters, the maximum value is 10km.
    /// </summary>
    [JsonProperty("visibility")]
    public int Visibility { get; set; }

    /// <summary>
    /// Information about the wind.
    /// </summary>
    [JsonProperty("wind")]
    public Wind Wind { get; set; }

    /// <summary>
    /// Information about the clouds.
    /// </summary>
    [JsonProperty("clouds")]
    public Clouds Clouds { get; set; }

#nullable enable

    /// <summary>
    /// Information about the rain, can be null if not available.
    /// </summary>
    [JsonProperty("rain")]
    public Rain? Rain { get; set; }

    /// <summary>
    /// Information about the snow, can be null if not available.
    /// </summary>
    [JsonProperty("snow")]
    public Snow? Snow { get; set; }

#nullable disable

    /// <summary>
    /// The exact moment of the analysis, in unix seconds, UTC.
    /// </summary>
    [JsonProperty("dt")]
    public long AnalysisDateUnix { get; set; }

    /// <summary>
    /// The exact moment of the analysis, UTC.
    /// </summary>
    public DateTime AnalysisDate
    {
        get { return DateTimeOffset.FromUnixTimeSeconds(AnalysisDateUnix).UtcDateTime; }
    }

    /// <summary>
    /// Internal parameters.
    /// </summary>
    [JsonProperty("sys")]
    public Internal Internal { get; set; }

    /// <summary>
    /// Shift in seconds from UTC.
    /// </summary>
    [JsonProperty("timezone")]
    public int Timezone { get; set; }

    /// <summary>
    /// The OpenWeatherMap City ID. More information in https://openweathermap.org/current#cityid
    /// </summary>
    [JsonProperty("id")]
    public long CityId { get; set; }

    /// <summary>
    /// The name of the city analyzed.
    /// </summary>
    [JsonProperty("name")]
    public string CityName { get; set; }

    /// <summary>
    /// The HTTP status code of the API call.
    /// </summary>
    [JsonProperty("cod")]
    public int StatusCode { get; set; }
}