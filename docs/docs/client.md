## WeatherClient
The library's client, that gets access to every feature in the namespace.
### Constructors
- *WeatherClient(apiKey)*: Creates a new WeatherClient object, from the user's [OpenWeatherMap API Key](https://openweathermap.org/appid).
    - *apiKey* (string): The [API key](https://openweathermap.org/appid).

### Properties
- *ApiKey* (string): The client's [API key](https://openweathermap.org/appid).

### Static Methods
- *GetWebpageAsync(url)*: Does a get request on a webpage and then returns the response asynchronously, checking for error codes.
    - *url* (string): The URL of the webpage.
    - *returns* (HttpResponseMessage): The response of the GET request.
- *GetWebpage(url)*: Does a get request on a webpage and then returns the response, checking for error codes.
    - *url* (string): The URL of the webpage.
    - *returns* (HttpResponseMessage): The response of the GET request.
- *GetWebpageStringAsync(url)*: Gets a webpage as a string asynchronously, checking for error codes.
    - *url* (string): The URL of the webpage.
    - *returns* (string): The webpage as a string.
- *GetWebpageStringAsync(url)*: Gets a webpage as a string, checking for error codes.
    - *url* (string): The URL of the webpage.
    - *returns* (string): The webpage as a string.
- *GetWebpageStreamAsync(url)*: Gets a webpage as a stream of bytes asynchronously, checking for error codes.
    - *url* (string): The URL of the webpage.
    - *returns* (Stream): The webpage as a stream of bytes.
- *GetWebpageStream(url)*: Gets a webpage as a stream of bytes, checking for error codes.
    - *url* (string): The URL of the webpage.
    - *returns* (Stream): The webpage as a stream of bytes.

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)