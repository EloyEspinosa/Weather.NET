namespace Weather.NET.Enums;

/// <summary>
/// Contains all available systems of measurement that can be used in the output.
/// </summary>
public enum Measurement
{
    /// <summary>
    /// Kelvin for temperature, meters for distances.
    /// </summary>
    Standard,

    /// <summary>
    /// Celsius for temperature, meters for distances.
    /// </summary>
    Metric,

    /// <summary>
    /// Fahrenheit for temperature, miles for distances.
    /// </summary>
    Imperial
}