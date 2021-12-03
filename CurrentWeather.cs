namespace Weather.NET
{
    /// <summary>
    /// Provides the current weather of a specific location.
    /// OpenWeather docs: https://openweathermap.org/current
    /// </summary>
    public static class CurrentWeather
    {
        private static readonly HttpClient client;

        static CurrentWeather()
        {
            client = new HttpClient();
        }

        /// <summary>
        /// Gets the current weather in a given city.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="format"> The format of the output. Can be: json, xml or html. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns> The output file as a string. </returns>
        public static string GetWithCityName(string name, string apiKey, string format = "json", string measurement = "standard", string language = "en")
        {
            string file;

            if (format == "json")
                file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?q={name}&appid={apiKey}&units={measurement}&lang={language}");
            else
                file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?q={name}&appid={apiKey}&mode={format}&units={measurement}&lang={language}");

            return file;
        }

        /// <summary>
        /// Gets the current weather in a given city asynchronously.
        /// More information in https://openweathermap.org/current#name
        /// </summary>
        /// <param name="name"> The name of the city. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="format"> The format of the output. Can be: json, xml or html. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns> The output file as a string. </returns>
        public static async Task<string> GetWithCityNameAsync(string name, string apiKey, string format = "json", string measurement = "standard", string language = "en")
        {
            string file;

            if (format == "json")
                file = await ReadWebpageAsync($"https://api.openweathermap.org/data/2.5/weather?q={name}&appid={apiKey}&units={measurement}&lang={language}");
            else
                file = await ReadWebpageAsync($"https://api.openweathermap.org/data/2.5/weather?q={name}&appid={apiKey}&mode={format}&units={measurement}&lang={language}");

            return file;
        }

        /// <summary>
        /// Gets the current weather in a given city.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="id"> The city id. More information in http://bulk.openweathermap.org/sample/ </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="format"> The format of the output. Can be: json, xml or html. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns> The output file as a string. </returns>
        public static string GetWithCityId(long id, string apiKey, string format = "json", string measurement = "standard", string language = "en")
        {
            string file;

            if (format == "json")
                file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?id={id}&appid={apiKey}&units={measurement}&lang={language}");
            else
                file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?id={id}&appid={apiKey}&mode={format}&units={measurement}&lang={language}");

            return file;
        }

        /// <summary>
        /// Gets the current weather in a given city asynchronously.
        /// More information in https://openweathermap.org/current#cityid
        /// </summary>
        /// <param name="id"> The city id. More information in http://bulk.openweathermap.org/sample/ </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="format"> The format of the output. Can be: json, xml or html. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns> The output file as a string. </returns>
        public static async Task<string> GetWithCityIdAsync(long id, string apiKey, string format = "json", string measurement = "standard", string language = "en")
        {
            string file;

            if (format == "json")
                file = await ReadWebpageAsync($"https://api.openweathermap.org/data/2.5/weather?id={id}&appid={apiKey}&units={measurement}&lang={language}");
            else
                file = await ReadWebpageAsync($"https://api.openweathermap.org/data/2.5/weather?id={id}&appid={apiKey}&mode={format}&units={measurement}&lang={language}");

            return file;
        }

        /// <summary>
        /// Gets the current weather in a given location.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="format"> The format of the output. Can be: json, xml or html. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns> The output file as a string. </returns>
        public static string GetWithGeoCoordinates(double latitude, double longitude, string apiKey, string format = "json", string measurement = "standard", string language = "en")
        {
            string file;

            if (format == "json")
                file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}&units={measurement}&lang={language}");
            else
                file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}&mode={format}&units={measurement}&lang={language}");

            return file;
        }

        /// <summary>
        /// Gets the current weather in a given location asynchronously.
        /// More information in https://openweathermap.org/current#geo
        /// </summary>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="format"> The format of the output. Can be: json, xml or html. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns> The output file as a string. </returns>
        public static async Task<string> GetWithGeoCoordinatesAsync(double latitude, double longitude, string apiKey, string format = "json", string measurement = "standard", string language = "en")
        {
            string file;

            if (format == "json")
                file = await ReadWebpageAsync($"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}&units={measurement}&lang={language}");
            else
                file = await ReadWebpageAsync($"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid={apiKey}&mode={format}&units={measurement}&lang={language}");

            return file;
        }

        /// <summary>
        /// Gets the current weather in a given location.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zipCode"> The ZIP code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="format"> The format of the output. Can be: json, xml or html. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns> The output file as a string. </returns>
        public static string GetWithZIPCode(string zipCode, string apiKey, string format = "json", string measurement = "standard", string language = "en")
        {
            string file;

            if (format == "json")
                file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}&units={measurement}&lang={language}");
            else
                file = ReadWebpage($"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}&mode={format}&units={measurement}&lang={language}");

            return file;
        }

        /// <summary>
        /// Gets the current weather in a given location asynchronously.
        /// More information in https://openweathermap.org/current#zip
        /// </summary>
        /// <param name="zipCode"> The ZIP code of the location. </param>
        /// <param name="apiKey"> The api key of the user. </param>
        /// <param name="format"> The format of the output. Can be: json, xml or html. </param>
        /// <param name="measurement"> The type of measurement of the output. Can be: standard, metric or imperial. </param>
        /// <param name="language"> The language of the output. Can be any of the given list: https://openweathermap.org/current#multi </param>
        /// <returns> The output file as a string. </returns>
        public static async Task<string> GetWithZIPCodeAsync(string zipCode, string apiKey, string format = "json", string measurement = "standard", string language = "en")
        {
            string file;

            if (format == "json")
                file = await ReadWebpageAsync($"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}&units={measurement}&lang={language}");
            else
                file = await ReadWebpageAsync($"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={apiKey}&mode={format}&units={measurement}&lang={language}");

            return file;
        }

        private static string ReadWebpage(string uri)
        {
            try
            {
                HttpResponseMessage response = client.GetAsync(uri).Result;
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().Result;
            }

            catch (HttpRequestException e)
            {
                Console.WriteLine("\nInternal Http Request Exception Caught!");
                Console.WriteLine($"Message: {e.Message}");
                throw new HttpRequestException(e.Message);
            }
        }

        private static async Task<string> ReadWebpageAsync(string uri)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }

            catch (HttpRequestException e)
            {
                Console.WriteLine("\nInternal Http Request Exception Caught!");
                Console.WriteLine($"Message: e.Message");
                throw new HttpRequestException(e.Message);
            }
        }
    }
}
