namespace Weather.NET;

internal static class RestApi
{
    internal static async Task<HttpResponseMessage> GetAsync(string url)
    {
        HttpResponseMessage response = await client.GetAsync(url);
        try { response.EnsureSuccessStatusCode(); }
        catch (HttpRequestException)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                    string message = (JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync())).message;
                    throw new HttpBadRequestException(message);

                case HttpStatusCode.Unauthorized:
                    throw new HttpUnauthorizedException("The given api key was invalid.");

                case HttpStatusCode.NotFound:
                    throw new HttpNotFoundException("The location was not available.");
                
                case HttpStatusCode.TooManyRequests:
                    throw new HttpTooManyRequestsException("The limit of calls per minute for your subscription was surpassed.");
                
                default:
                    throw new HttpRequestException("An internal error in OpenWeatherMap ocurred. It is recommended to contact OpenWeatherMap API in https://home.openweathermap.org/questions.");
            }
        }

        return response;
    }

    internal static async Task<string> GetWebpageStringAsync(string url) => await (await GetAsync(url)).Content.ReadAsStringAsync();
    internal static async Task<Stream> GetWebpageStreamAsync(string url) => await (await GetAsync(url)).Content.ReadAsStreamAsync();

    private static readonly HttpClient client = new HttpClient();
}