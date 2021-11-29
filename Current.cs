using System;
using System.IO;
using System.Net;

namespace Weather.NET
{
    /// <summary>
    /// Provides the current weather of a specific location.
    /// OpenWeather docs: https://openweathermap.org/current
    /// </summary>
    public static class Current
    {
        private static WebClient client = new WebClient();
        public static string GetCityJSON(string name, string apiKey, string measurement="standard", string language="en")
        {
            try
            {
                Stream stream = client.OpenRead($"https://api.openweathermap.org/data/2.5/weather?q={name}&appid={apiKey}&units={measurement}&lang={language}");
                StreamReader reader = new StreamReader(stream);
                string json = reader.ReadToEnd();

                stream.Close();
                reader.Close();
                return json;
            }

            catch (WebException e) { throw new WebException($"Something went wrong internally. Exception: {e.Message}"); }
        }
    }
}
