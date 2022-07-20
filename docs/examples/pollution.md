## AirPollution example
This code examples shows how to use the library to get information related to AirPollution.

```c#
using System;
using Weather.NET;
using Weather.NET.Models.PollutionModel;

namespace Weather.NET.Examples;

public static class AirPollutionExample
{
    // Use your API key here.
    public static WeatherClient Client = new WeatherClient("This is not a fake API key. Please, please believe me.");

    public static void CurrentExample()
    {
        // Gets the current air pollution.
        PollutionModel currentPollution = Client.GetCurrentAirPollution(39.9075, 116.3972);

        Console.WriteLine(currentPollution.AirDescriptions[0].AnalysisDate);
        Console.WriteLine(currentPollution.AirDescriptions[0].AirQualityDescription);
    }

    public static async Task ForecastExample()
    {
        // Gets a forecast of the air pollution.
        PollutionModel futurePollution = Client.GetForecastAirPollution(19.0144, 72.8479);

        Console.WriteLine(futurePollution.AirDescriptions[0].AnalysisDate);
        Console.WriteLine(futurePollution.AirDescriptions[0].AirQualityDescription);
    }

    public static async Task HistoricalExample()
    {
        // Gets a historical record of the air pollution from 2 days ago to yesterday.
        PollutionModel historicalPollution = Client.GetHistoricalAirPollution(55.7522, 37.6156, DateTimeOffset.Now.ToUnixTimeSeconds() - (86400 * 2), DateTimeOffset.Now.ToUnixTimeSeconds() - 86400);

        foreach (AirDescription description in historicalPollution.AirDescriptions)
        {
            Console.WriteLine(description.AnalysisDate);
            Console.WriteLine(description.AirQualityDescription);
            Console.WriteLine();
        }
    }
}
```

[Back](https://eloyespinosa.github.io/Weather.NET/examples)