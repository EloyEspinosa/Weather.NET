## CurrentWeather Example
This code example shows how to use the library to get the current weather of a location.

```c#
using System;
using Weather.NET;
using Weather.NET.Enums;
using Weather.NET.Models.WeatherModel;

namespace Weather.NET.Examples;

public static class CurrentWeatherExample
{
    // Use your API key here.
    public static WeatherClient Client = new WeatherClient("This is an API key. I swear.");
    
    public static void StandardExample
    {
        // Uses Measurement.Standard as a measurement system, and Language.English as a language.
        WeatherModel currentWeather = Client.GetCurrentWeather("Brighton");
        
        Console.WriteLine(currentWeather.Weather[0].Title);
        Console.WriteLine(currentWeather.Weather[0].Description);
        Console.WriteLine(currentWeather.Main.Temperature);
    }
    
    public static async Task MetricExample
    {
        WeatherModel currentWeather = await Client.GetCurrentWeatherAsync(48.2085, 16.3721, Measurement.Metric, Language.German);
        
        Console.WriteLine(currentWeather.Weather[0].Title);
        Console.WriteLine(currentWeather.Weather[0].Description);
        Console.WriteLine(currentWeather.Main.Temperature);
    }
    
    public static void ImperialExample
    {
        // This is another way of using the GetCurrentWeather method.
        WeatherModel currentWeather = CurrentWeathe.GetCurrentWeather(Client, 10001, "US", measurement: Measurement.Imperial);
        
        Console.WriteLine(currentWeather.Weather[0].Title);
        Console.WriteLine(currentWeather.Weather[0].Description);
        Console.WriteLine(currentWeather.Main.Temperature);
    }
}
```

[Back to main page](https://eloyespinosa.github.io/Weather.NET/)
