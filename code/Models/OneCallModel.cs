namespace Weather.NET.Models.OneCallModel;

/// <summary>
/// Gets the One Call API information about the current weather.
/// </summary>
public class Current
{
    /// <summary>
    /// The analysis date in unix seconds, UTC.
    /// </summary>
    [JsonProperty("dt")]
    public long AnalysisDate { get; set; }

    /// <summary>
    /// The sunrise time in unix seconds, UTC.
    /// </summary>
    [JsonProperty("sunrise")]
    public long SunriseTime { get; set; }

    /// <summary>
    /// The sunset time in unix seconds, UTC.
    /// </summary>
    [JsonProperty("sunset")]
    public long SunsetTime { get; set; }

    /// <summary>
    /// The temperature of the location, depends on the measurement system.
    /// </summary>
    [JsonProperty("temp")]
    public double Temperature { get; set; }

    /// <summary>
    /// The temperature of the location, depends on the measurement system.
    /// </summary>
    [JsonProperty("feels_like")]
    public double TemperaturePerception { get; set; }

    /// <summary>
    /// The atmospheric pressure in the sea level, in hPa.
    /// </summary>
    [JsonProperty("pressure")]
    public int AtmosphericPressure { get; set; }

    /// <summary>
    /// The humidity (%) of the location.
    /// </summary>
    [JsonProperty("humidity")]
    public int HumidityPercentage { get; set; }

    /// <summary>
    /// The atmospheric temperature (that varies according to pressure and humidity), below which water droplets begin to condense and dew can form. Depends on the measurement system.
    /// </summary>
    [JsonProperty("dew_point")]
    public double DewPoint { get; set; }

    /// <summary>
    /// The current UV index, can be null in places where it is not available.
    /// </summary>
    [JsonProperty("uvi")]
    public double? UVIndex { get; set; }

    /// <summary>
    /// The percentage of clouds in the sky.
    /// </summary>
    [JsonProperty("clouds")]
    public int CloudPercentage { get; set; }

    /// <summary>
    /// The average visibility in meters.
    /// </summary>
    [JsonProperty("visibility")]
    public int Visibility { get; set; }

    /// <summary>
    /// The speed of the wind, depends on the measurement system.
    /// </summary>
    [JsonProperty("wind_speed")]
    public double WindSpeed { get; set; }

    /// <summary>
    /// The direction of the wind in degrees.
    /// </summary>
    [JsonProperty("wind_deg")]
    public int WindDirection { get; set; }

    /// <summary>
    /// Information and a description of the weather.
    /// </summary>
    [JsonProperty("weather")]
    public WeatherModel.Weather[] Description { get; set; }
}

/// <summary>
/// Gets the One Call API information about a minutely forecast of the weather.
/// </summary>
public class Minutely
{
    /// <summary>
    /// Time of the forecasted data in unix seconds, UTC.
    /// </summary>
    [JsonProperty("dt")]
    public long AnalysisDate { get; set; }

    /// <summary>
    /// The precipitation in milimeters.
    /// </summary>
    [JsonProperty("precipitation")]
    public double PrecipitationVolume { get; set; }
}

/// <summary>
/// Gets the One Call API information about an hourly forecast of the weather.
/// </summary>
public class Hourly
{
    /// <summary>
    /// The analysis date of the forecast in unix seconds, UTC.
    /// </summary>
    [JsonProperty("dt")]
    public long AnalysisDate { get; set; }

    /// <summary>
    /// The temperature, depends on the measurement system.
    /// </summary>
    [JsonProperty("temp")]
    public double Temperature { get; set; }

    /// <summary>
    /// The temperature, accounting for the human perception of temperature. Depends on the measurement system.
    /// </summary>
    [JsonProperty("feels_like")]
    public double TemperaturePerception { get; set; }

    /// <summary>
    /// The atmospheric pressure on the sea level, in hPa.
    /// </summary>
    [JsonProperty("pressure")]
    public int AtmosphericPressure { get; set; }

    /// <summary>
    /// The humidity (%).
    /// </summary>
    [JsonProperty("humidity")]
    public int HumidityPercentage { get; set; }

    /// <summary>
    /// The atmospheric temperature (that varies according to pressure and humidity), below which water droplets begin to condense and dew can form.
    /// </summary>
    [JsonProperty("dew_point")]
    public double DewPoint { get; set; }

    /// <summary>
    /// The UV index. Can be null if not available.
    /// </summary>
    [JsonProperty("uvi")]
    public double? UVIndex { get; set; }

    /// <summary>
    /// The amount of clouds in the sky (%).
    /// </summary>
    [JsonProperty("clouds")]
    public int CloudPercentage { get; set; }

    /// <summary>
    /// The average visibility in meters.
    /// </summary>
    [JsonProperty("visibility")]
    public int? Visibility { get; set; }

    /// <summary>
    /// The speed of the wind, depends on the measurement system.
    /// </summary>
    [JsonProperty("wind_speed")]
    public double WindSpeed { get; set; }

    /// <summary>
    /// The direction of the wind, in degrees.
    /// </summary>
    [JsonProperty("wind_deg")]
    public int WindDirection { get; set; }

    /// <summary>
    /// The probability of precepitation, can be null if not available.
    /// </summary>
    [JsonProperty("pop")]
    public double? PrecipitationProbability { get; set; }

    /// <summary>
    /// Information and a description of the weather.
    /// </summary>
    [JsonProperty("weather")]
    public WeatherModel.Weather[] Description { get; set; }
}

/// <summary>
/// Contains information about the temperature in the day.
/// </summary>
public class DayTemperature
{
    /// <summary>
    /// The morning temperature.
    /// </summary>
    [JsonProperty("morn")]
    public double Morning { get; set; }

    /// <summary>
    /// The day temperature.
    /// </summary>
    [JsonProperty("day")]
    public double Day { get; set; }

    /// <summary>
    /// The evening temperature.
    /// </summary>
    [JsonProperty("eve")]
    public double Evening { get; set; }

    /// <summary>
    /// The night temperature.
    /// </summary>
    [JsonProperty("night")]
    public double Night { get; set; }

    /// <summary>
    /// The minimum temperature of the day.
    /// </summary>
    [JsonProperty("min")]
    public double Minimum { get; set; }

    /// <summary>
    /// The maximum temperature of the day.
    /// </summary>
    [JsonProperty("max")]
    public double Maximum { get; set; }
}

/// <summary>
/// Contains information about the temperature of the day, accounting for the human perception of temperature.
/// </summary>
public class DayTemperaturePerception
{
    /// <summary>
    /// The morning temperature, accounting for the human perception of temperature.
    /// </summary>
    [JsonProperty("morn")]
    public double Morning { get; set; }

    /// <summary>
    /// The day temperature, accounting for the human perception of temperature.
    /// </summary>
    [JsonProperty("day")]
    public double Day { get; set; }

    /// <summary>
    /// The evening temperature, accounting for the human perception of temperature.
    /// </summary>
    [JsonProperty("eve")]
    public double Evening { get; set; }

    /// <summary>
    /// The night temperature, accounting for the human perception of temperature.
    /// </summary>
    [JsonProperty("night")]
    public double Night { get; set; }
}

/// <summary>
/// Gets the One Call API information about a daily forecast.
/// </summary>
public class Daily
{
    /// <summary>
    /// Time of the forecasted data in unix seconds, UTC.
    /// </summary>
    [JsonProperty("dt")]
    public long AnalysisDate { get; set; }

    /// <summary>
    /// The sunrise time in unix seconds, UTC.
    /// </summary>
    [JsonProperty("sunrise")]
    public long SunriseTime { get; set; }

    /// <summary>
    /// The sunset time in unix seconds, UTC.
    /// </summary>
    [JsonProperty("sunset")]
    public long SunsetTime { get; set; }

    /// <summary>
    /// The moonrise time in unix seconds, UTC.
    /// </summary>
    [JsonProperty("moonrise")]
    public long MoonriseTime { get; set; }

    /// <summary>
    /// The moonset time in unix seconds, UTC.
    /// </summary>
    [JsonProperty("moonset")]
    public long MoonsetTime { get; set; }

    /// <summary>
    /// The moon phase:<br />
    /// - 0 and 1: New moon.<br />
    /// - 0 to 0.25 (exclusive): Waxing crescent.<br />
    /// - 0.25: First quarter moon.<br />
    /// - 0.25 to 0.5 (exclusive): Waxing gibous.<br />
    /// - 0.5: Full moon.<br />
    /// - 0.5 to 0.75 (exclusive): Waning gibous.<br />
    /// - 0.75: Last quarter moon.<br />
    /// - 0.75 to 1 (exclusive): Waning crescent.
    /// </summary>
    [JsonProperty("moon_phase")]
    public double MoonPhaseIndex { get; set; }

    /// <summary>
    /// The moon phase in english.
    /// </summary>
    public string MoonPhase {
        get
        {
            if (MoonPhaseIndex == 0 || MoonPhaseIndex == 1)
                return "new moon";

            else if (MoonPhaseIndex == 0.25)
                return "first quarter moon";

            else if (MoonPhaseIndex == 0.5)
                return "full moon";
            
            else if (MoonPhaseIndex == 0.75)
                return "last quarter moon";
            
            else if (MoonPhaseIndex < 0.25)
                return "waxing crescent";
            
            else if (MoonPhaseIndex < 0.5)
                return "waxing gibous";
            
            else if (MoonPhaseIndex < 0.75)
                return "waning gibous";
            
            else return "waning crescent";
        }
    }

    /// <summary>
    /// Description of the temperature of the day, depends on the measurement system.
    /// </summary>
    [JsonProperty("temp")]
    public DayTemperature Temperature { get; set; }

    /// <summary>
    /// Description of the temperature of the day, accounting for the human perception of temperature. Depends on the measurement system.
    /// </summary>
    [JsonProperty("feels_like")]
    public DayTemperaturePerception TemperaturePerception { get; set; }

    /// <summary>
    /// Atmospheric pressure on the sea level, in hPa.
    /// </summary>
    [JsonProperty("pressure")]
    public int AtmosphericPressure { get; set; }

    /// <summary>
    /// The humidity (%).
    /// </summary>
    [JsonProperty("humidity")]
    public int HumidityPercentage { get; set; }

    /// <summary>
    /// The atmospheric temperature (that varies according to pressure and humidity), below which water droplets begin to condense and dew can form.
    /// Depends on the measurement system.
    /// </summary>
    [JsonProperty("dew_point")]
    public double DewPoint { get; set; }

    /// <summary>
    /// The speed of the wind. Depends on the measurement system.
    /// </summary>
    [JsonProperty("wind_speed")]
    public double WindSpeed { get; set; }

    /// <summary>
    /// The direction of the wind in degrees.
    /// </summary>
    [JsonProperty("wind_deg")]
    public int WindDirection { get; set; }

    /// <summary>
    /// The amount of clouds in the sky (%).
    /// </summary>
    [JsonProperty("clouds")]
    public int CloudPercentage { get; set; }

    /// <summary>
    /// The maximum UV index of the day.
    /// </summary>
    [JsonProperty("uvi")]
    public double UVIndex { get; set; }

    /// <summary>
    /// The probability of precipitation.
    /// </summary>
    [JsonProperty("pop")]
    public double PrecipitationProbability { get; set; }

    /// <summary>
    /// Information and a description of the weather.
    /// </summary>
    [JsonProperty("weather")]
    public WeatherModel.Weather[] Description { get; set; }
}

/// <summary>
/// Contains national weather alerts from major national weather warning systems of the area.
/// Might be in english, or in the local language.
/// </summary>
public class Alerts
{
    /// <summary>
    /// The name of the sender of the alert.
    /// </summary>
    [JsonProperty("sender_name")]
    public string Sender { get; set; }

    /// <summary>
    /// The event of the alert.
    /// </summary>
    [JsonProperty("event")]
    public string Event { get; set; }

    /// <summary>
    /// The date and time of the start of the alert in unix seconds, UTC.
    /// </summary>
    [JsonProperty("start")]
    public long Start { get; set; }

    /// <summary>
    /// The date and time of the end of the alert in unix seconds, UTC.
    /// </summary>
    [JsonProperty("end")]
    public long End { get; set; }

    /// <summary>
    /// The alert.
    /// </summary>
    [JsonProperty("description")]
    public string Description { get; set; }
    
    /// <summary>
    /// Tags of the alert.
    /// </summary>
    [JsonProperty("tags")]
    public string[] Tags { get; set; }
}

/// <summary>
/// Contains all of the parameters of a One Call API response.
/// </summary>
public class OneCallModel
{
    /// <summary>
    /// The latitude of the location analyzed.
    /// </summary>
    [JsonProperty("lat")]
    public double Latitude { get; set; }

    /// <summary>
    /// The longitude of the location analyzed.
    /// </summary>
    [JsonProperty("lon")]
    public double Longitude { get; set; }

    /// <summary>
    /// The name of the location's timezone.
    /// </summary>
    [JsonProperty("timezone")]
    public string TimezoneName { get; set; }

    /// <summary>
    /// Shift in seconds from UTC.
    /// </summary>
    [JsonProperty("timezone_offset")]
    public int TimezoneOffset { get; set; }

    /// <summary>
    /// The analysis date in unix seconds, accounting for the location's timezones.
    /// </summary>
    public long AnalysisDateTimezone { get { return CurrentWeather.AnalysisDate + TimezoneOffset; } }

#nullable enable

    /// <summary>
    /// The current weather, can be null if excluded.
    /// </summary>
    [JsonProperty("current")]
    public Current? CurrentWeather { get; set; }

    /// <summary>
    /// A list of minutely forecasts for 1 hour, that contain only the precipitation volume. Can be null if excluded or not available.
    /// </summary>
    [JsonProperty("minutely")]
    public Minutely[]? MinutelyForecasts { get; set; }

    /// <summary>
    /// A list of hourly forecasts for 2 days. Can be null if excluded.
    /// </summary>
    [JsonProperty("hourly")]
    public Hourly[]? HourlyForecasts { get; set; }

    /// <summary>
    /// A list of daily forecasts for a week, can be null if excluded or not available.
    /// </summary>
    [JsonProperty("daily")]
    public Daily[]? DailyForecasts { get; set; }

    /// <summary>
    /// A list of national alerts from major national weather warning systems for the previous 5 days,
    /// the alerts can be either in english or in a local language. Can be null if excluded or not available.
    /// </summary>
    [JsonProperty("alerts")]
    public Alerts[]? NationalAlerts { get; set; }
}