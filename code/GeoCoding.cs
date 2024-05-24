using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security;
using Weather.NET.Models.GeoCodingModel;

namespace Weather.NET;

/// <summary>
/// OpenWeather's transformation of any location name into geographical coordinates, and the other way around (reverse geocoding) (1.0).
/// More information in https://openweathermap.org/api/geocoding-api
/// </summary>
public static class GeoCoding
{
    /// <summary>
    /// Direct geocoding allows to get geographical coordinates (lat, lon) by using name of the location (city name or area name). If you use the limit parameter in the API call, you can cap how many locations with the same name will be seen in the API response (for instance, London in the UK and London in the US)
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="cityName"> The city name. </param>
    /// <param name="stateCode"> The state code (only for the US). </param>
    /// <param name="countryCode"> The ISO 3166 country code. </param>
    /// <param name="limit"> Number of the locations in the API response (up to 5 results can be returned in the API response). </param>
    /// <returns> Returns up to 5 LocationCoordinates that match the query. </returns>
    public static List<CoordinatesByLocationNameResponse> CoordinatesByLocationName(this WeatherClient client,
        string cityName, string stateCode, string countryCode, int limit) =>
        Task.Run(() => client.CoordinatesByLocationNameAsync(cityName, stateCode, countryCode, limit)).Result;


    /// <summary>
    /// Converts a zip/postal code to coordinates.
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="zipCode"> The zip/post code. </param>
    /// <param name="countryCode"> The ISO 3166 country code. </param>
    /// <returns> Returns up to 5 LocationCoordinates that match the query. </returns>
    public static CoordinatesByZipCodeResponse CoordinatesByZipCode(this WeatherClient client,
        string zipCode, string countryCode) =>
        Task.Run(() => client.CoordinatesByZipCodeAsync(zipCode, countryCode)).Result;

    /// <summary>
    /// Reverse geocoding allows to get name of the location (city name or area name) by using geografical coordinates (lat, lon). The limit parameter in the API call allows you to cap how many location names you will see in the API response.
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="latitude"> Latitude. </param>
    /// <param name="longitude"> Longitude. </param>
    /// <param name="limit"> Number of the locations in the API response (up to 5 results can be returned in the API response). </param>
    /// <returns> Returns up to 5 LocationCoordinates that match the query. </returns>
    public static List<LocationNameByCoordinatesResponse> LocationNameByCoordinates(this WeatherClient client,
        double latitude, double longitude, int limit) =>
        Task.Run(() => client.LocationNameByCoordinatesResponseAsync(latitude, longitude, limit)).Result;

    /// <summary>
    /// Direct geocoding allows to get geographical coordinates (lat, lon) by using name of the location (city name or area name). If you use the limit parameter in the API call, you can cap how many locations with the same name will be seen in the API response (for instance, London in the UK and London in the US)
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="cityName"> The city name. </param>
    /// <param name="stateCode"> The state code (only for the US). </param>
    /// <param name="countryCode"> The ISO 3166 country code. </param>
    /// <param name="limit"> Number of the locations in the API response (up to 5 results can be returned in the API response). </param>
    /// <returns> Returns up to 5 LocationCoordinates that match the query. </returns>
    public static async Task<List<CoordinatesByLocationNameResponse>> CoordinatesByLocationNameAsync(this WeatherClient client,
        string cityName, string stateCode, string countryCode, int limit)
    {
        string file = await RestApi.GetWebpageStringAsync($"https://api.openweathermap.org/geo/1.0/direct?q={cityName},{stateCode},{countryCode}&limit={limit}&appid={client.ApiKey}");
        return JsonConvert.DeserializeObject<List<CoordinatesByLocationNameResponse>>(file);
    }

    /// <summary>
    /// Converts a zip/postal code to coordinates.
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="zipCode"> The zip/post code. </param>
    /// <param name="countryCode"> The ISO 3166 country code. </param>
    /// <returns> Returns up to 5 LocationCoordinates that match the query. </returns>
    public static async Task<CoordinatesByZipCodeResponse> CoordinatesByZipCodeAsync(this WeatherClient client,
        string zipCode, string countryCode)
    {
        string file = await RestApi.GetWebpageStringAsync($"https://api.openweathermap.org/geo/1.0/zip?zip={zipCode},{countryCode}&appid={client.ApiKey}");
        return JsonConvert.DeserializeObject<CoordinatesByZipCodeResponse>(file);
    }

    /// <summary>
    /// Reverse geocoding allows to get name of the location (city name or area name) by using geografical coordinates (lat, lon). The limit parameter in the API call allows you to cap how many location names you will see in the API response.
    /// </summary>
    /// <param name="client"> The client, that contains the API key. </param>
    /// <param name="latitude"> Latitude. </param>
    /// <param name="longitude"> Longitude. </param>
    /// <param name="limit"> Number of the locations in the API response (up to 5 results can be returned in the API response). </param>
    /// <returns> Returns up to 5 LocationCoordinates that match the query. </returns>
    public static async Task<List<LocationNameByCoordinatesResponse>> LocationNameByCoordinatesResponseAsync(this WeatherClient client,
        double latitude, double longitude, int limit)
    {
        string file = await RestApi.GetWebpageStringAsync($"https://api.openweathermap.org/geo/1.0/reverse?lat={latitude}&lon={longitude}&limit={limit}&appid={client.ApiKey}");
        return JsonConvert.DeserializeObject<List<LocationNameByCoordinatesResponse>>(file);
    }

}