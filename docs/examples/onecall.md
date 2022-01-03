## OneCallApi example
This code example shows how to use the library to use OpenWeather's One Call API.

```c#
using System;
using Weather.NET;
using Weather.NET.Enums;
using Weather.NET.Models.OneCallModel;

namespace Weather.NET.Examples;

public static class OneCallExample
{
    // Use your API key here.
    public static WeatherClient Client = new WeatherClient("Don't mind me, this is a completely normal API key.");

    public static async Task CurrentExample()
    {
        // Only excludes the national alerts.
        OneCallModel currentOneCall = await Client.GetOneCallAsync(35.6895, 139.6917, new ExcludeOneCall[]{ExcludeOneCall.Minutely}, Measurement.Metric, Language.Japanese);

        Console.WriteLine(currentOneCall.CurrentWeather.Temperature);
        Console.WriteLine(currentOneCall.HourlyForecasts[24].Temperature);
        Console.WriteLine(currentOneCall.DailyForecasts[3].Temperature.Minimum);
        Console.WriteLine(currentOneCall.DailyForecasts[3].Temperature.Maximum);
        Console.WriteLine(currentOneCall.NationalAlerts[0].Event);
        Console.WriteLine(currentOneCall.NationalAlerts[0].Description);
    }

    public static void HistoricalExample()
    {
        // Gets the historical One Call API of 2021-12-30.
        OneCallModel historicalOneCall = OneCallApi.GetHistoricalOneCall(Client, -22.9028, -43.2075, 1640906598, Measurement.Metric, Language.BrazilianPortuguese);

        Console.WriteLine(currentOneCall.HourlyForecasts[12].Description[0].Title);
        Console.WriteLine(currentOneCall.HourlyForecasts[12].Description[0].Description);
        Console.WriteLine(currentOneCall.HourlyForecasts[12].Temperature);
    }
}
```

[Back](https://eloyespinosa.github.io/Weather.NET/examples)