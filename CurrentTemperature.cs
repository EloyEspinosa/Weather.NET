using System;
using Newtonsoft.Json;

namespace Weather.NET
{
    /// <summary>
    /// Provides the temperature of a specific location.
    /// </summary>
    public static class CurrentTemperature
    {
        public static double GetWithCityName(string name, string apiKey, string format = "json", string measurement = "standard", string language = "en")
        {
            string file = CurrentWeather.GetWithCityName(name, apiKey, format, measurement, language);
            var json = JsonConvert.DeserializeObject<dynamic>(file);
            return json.main.temp;
        }
    }
}