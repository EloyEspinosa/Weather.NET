namespace Weather.NET.Models.GeoCodingModel;

public class CoordinatesByLocationNameResponse
{
    /// <summary>
    /// Name of the found location 
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("local_names")]
    public IDictionary<string, string> LocalNames { get; set; }
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
    /// <summary>
    /// (where available) State of the found location 
    /// </summary>
    [JsonProperty("state")]
    public string State { get; set; }
}

public class LocalName
{
    public string LanguageCode { get; set; }
    public string Name { get; set; }
}

public class CoordinatesByZipCodeResponse
{
    /// <summary>
    /// Specified zip/post code in the API request 
    /// </summary>
    [JsonProperty("zip")]
    public string ZipCode { get; set; }
    /// <summary>
    /// Name of the found area 
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }
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
}

public class LocationNameByCoordinatesResponse : CoordinatesByLocationNameResponse
{
}
