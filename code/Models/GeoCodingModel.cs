namespace Weather.NET.Models.GeoCodingModel;

public class GeoCodingModel
{
    /// <summary>
    /// Name of the found location.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
#nullable enable
    /// <summary>
    /// Local names of the found location, if available.
    /// </summary>
    [JsonProperty("local_names")]
    public IDictionary<string, string>? LocalNames { get; set; }
#nullable disable
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
    /// Country of the found location 
    /// </summary>
    [JsonProperty("country")]
    public string Country { get; set; }
#nullable enable
    /// <summary>
    /// State of the found location, where available.
    /// </summary>
    [JsonProperty("state")]
    public string? State { get; set; }

    /// <summary>
    /// Zip code of the found location, if available.
    /// </summary>
    [JsonProperty("zip")]
    public string? ZipCode { get; set; }
}