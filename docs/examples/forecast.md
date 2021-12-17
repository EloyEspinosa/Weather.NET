## FutureWeather Example
This code example shows how to use the library to get the current weather of a location.

```c#
using System;
using Weather.NET;
using Weather.NET.Enums;
using Weather.NET.Models.WeatherModel;

namespace Weather.NET.Examples;

public static class FutureWeatherExample
{
    // Use your API key here.
    public static WeatherClient Client = new WeatherClient("This is a real api key. Trust me.");
    
    public static void StandardExample
    {
        // Uses Measurement.Standard as a measurement system, and Language.English as a language.
        List<WeatherModel> forecasts = Client.GetForecast("Canberra", 8);
        
        foreach (WeatherModel forecast in forecasts)
        {
            // Prints the time of the forecast in UTC.
            Console.WriteLine(DateTimeOffset.FromUnixTimeSeconds(forecast.AnalysisDate).ToString());
            Console.WriteLine(forecast.Main.Temperature);
        }
    }
    
    public static async Task MetricExample
    {
        List<WeatherModel> forecasts = await Client.GetForecastAsync(3448439, 3, Measurement.Metric, Language.BrazilianPortuguese);
        foreach (var forecast in forecasts)
        {
            // Prints the time of the forecast in UTC.
            Console.WriteLine(DateTimeOffset.FromUnixTimeSeconds(forecast.AnalysisDate).ToString());
            Console.WriteLine(forecast.Main.Temperature);
        }
    }
    
    public static void ImperialExample
    {
        var forecasts = FutureWeather.GetForecast(38.300, -76.507, 40, measurement: Measurement.Imperial);
        foreach (var forecast in forecasts)
        {
            // Prints the time of the forecast in UTC.
            Console.WriteLine(DateTimeOffset.FromUnixTimeSeconds(forecast.AnalysisDate).ToString());
            Console.WriteLine(forecast.Main.Temperature);
        }
    }
}
```

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)
