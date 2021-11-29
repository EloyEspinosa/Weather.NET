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

        /// <summary>
        /// Gets the JSON file of the given search.
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns> The JSON file as a string. </returns>
        /// <exception cref="WebException"></exception>
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
