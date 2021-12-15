namespace Weather.NET.Extensions;

internal static class MeasurementHelper
{
    private static readonly string[] measurementSystems = { "standard", "metric", "imperial" };
    internal static string Convert(this Measurement system) => measurementSystems[(int)system];
}