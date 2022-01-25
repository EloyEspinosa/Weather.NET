namespace Weather.NET.Models.PollutionModel;

/// <summary>
/// Contains the Air Quality index.
/// </summary>
public class Index
{
    /// <summary>
    /// The Air Quality index of the location analyzed.
    /// Possible values:<br />
    /// - 1: Good.<br />
    /// - 2: Fair.<br />
    /// - 3: Moderate.<br />
    /// - 4: Poor.<br />
    /// - 5: Very Poor.
    /// </summary>
    [JsonProperty("aqi")]
    public int AirQuality { get; set; }
}

/// <summary>
/// Contains specific information about different components in the air.
/// </summary>
public class AirComponents
{
    /// <summary>
    /// Concentration of Carbon Monoxide in the air, in micrograms per cubic meter.
    /// </summary>
    [JsonProperty("co")]
    public double CarbonMonoxide { get; set; }

    /// <summary>
    /// Concentration of Nitrogen Monoxide in the air, in micrograms per cubic meter.
    /// </summary>
    [JsonProperty("no")]
    public double NitrogenMonoxide { get; set; }

    /// <summary>
    /// Concentration of Nitrogen Dioxide in the air, in micrograms per cubic meter.
    /// </summary>
    [JsonProperty("no2")]
    public double NitrogenDioxide { get; set; }

    /// <summary>
    /// Concentration of Ozone in the air, in micrograms per cubic meter.
    /// </summary>
    [JsonProperty("o3")]
    public double Ozone { get; set; }

    /// <summary>
    /// Concentration of Sulphur Dioxide in the air, in micrograms per cubic meter.
    /// </summary>
    [JsonProperty("so2")]
    public double SulphurDioxide { get; set; }

    /// <summary>
    /// Concentration of fine particles matter in the air, in micrograms per cubic meter.
    /// </summary>
    [JsonProperty("pm2_5")]
    public double FineParticulateMatter { get; set; }

    /// <summary>
    /// Concentration of coarse particulate matter in the air, in micrograms per cubic meter.
    /// </summary>
    [JsonProperty("pm10")]
    public double CoarseParticulateMatter { get; set; }

    /// <summary>
    /// Concentration of ammonia in the air, in micrograms per cubic meter.
    /// </summary>
    [JsonProperty("nh3")]
    public double Ammonia { get; set; }
}

/// <summary>
/// Contains the information about the air of the location analyzed.
/// </summary>
public class AirDescription
{
    /// <summary>
    /// The moment of the analysis in Unix seconds (UTC).
    /// </summary>
    [JsonProperty("dt")]
    public long AnalysisDate { get; set; }

    /// <summary>
    /// Contains the Air Quality index.
    /// </summary>
    [JsonProperty("main")]
    public Index Main { get; set; }

    /// <summary>
    /// The Air Quality index, in english.
    /// </summary>
    public string AirQualityDescription { get { return _aqi[Main.AirQuality]; } }

    /// <summary>
    /// Contains specific information about different components in the air.
    /// </summary>
    [JsonProperty("components")]
    public AirComponents AirComponents { get; set; }

    private string[] _aqi = { "error", "Good", "Fair", "Moderate", "Poor", "Very Poor" };
}

/// <summary>
/// Contains all parameters in an Air Pollution API response.
/// </summary>
public class PollutionModel
{
    /// <summary>
    /// Contains the coordinates of the location analyzed. Index 0 is latitude, and index 1 is longitude.
    /// </summary>
    [JsonProperty("coord")]
    public Location Coordinates { get; set; }

    /// <summary>
    /// Contains the information about the air of the location analyzed.
    /// </summary>
    [JsonProperty("list")]
    public List<AirDescription> AirDescriptions { get; set; }
}