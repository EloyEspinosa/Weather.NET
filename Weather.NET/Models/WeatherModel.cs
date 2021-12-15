namespace Weather.NET.Models.WeatherModel;

public class Location
{
    [JsonProperty("lon")]
    public double Longitude { get; set; }

    [JsonProperty("lat")]
    public double Latitude { get; set; }
}

public class Weather
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("main")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("icon")]
    public string IconId { get; set; }

    public string IconUrl { get { return $"https://openweathermap.org/img/w/{IconId}.png"; } }
}

public class Main
{
    [JsonProperty("temp")]
    public double Temperature { get; set; }

    [JsonProperty("feels_like")]
    public double TemperaturePerception { get; set; }

    [JsonProperty("temp_min")]
    public double TemperatureMin { get; set; }

    [JsonProperty("temp_max")]
    public double TemperatureMax { get; set; }

    [JsonProperty("pressure")]
    public int AtmosphericPressure { get; set; }

    [JsonProperty("humidity")]
    public int HumidityPercentage { get; set; }
}

public class Wind
{
    [JsonProperty("speed")]
    public double Speed { get; set; }

    [JsonProperty("deg")]
    public int Direction { get; set; }
}

public class Clouds
{
    [JsonProperty("all")]
    public int Percentage { get; set; }
}

public class Internal
{
    [JsonProperty("message")]
    public double Message { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("sunrise")]
    public long SunriseUnix { get; set; }

    [JsonProperty("sunset")]
    public long SunsetUnix { get; set; }
}

public class WeatherModel
{
    [JsonProperty("coord")]
    public Location Location { get; set; }

    [JsonProperty("weather")]
    public List<Weather> Weather { get; set; }

    [JsonProperty("main")]
    public Main Main { get; set; }

    [JsonProperty("visibility")]
    public int Visibility { get; set; }

    [JsonProperty("wind")]
    public Wind Wind { get; set; }

    [JsonProperty("clouds")]
    public Clouds Clouds { get; set; }

    [JsonProperty("dt")]
    public long AnalysisDate { get; set; }

    [JsonProperty("sys")]
    public Internal Internal { get; set; }

    [JsonProperty("timezone")]
    public int Timezone { get; set; }

    [JsonProperty("id")]
    public long CityId { get; set; }

    [JsonProperty("name")]
    public string CityName { get; set; }

    [JsonProperty("cod")]
    public int Cod { get; set; }
}