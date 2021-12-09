namespace Weather.NET
{
    /// <summary>
    /// Contains constants for all available measurement systems.
    /// </summary>
    public static class WeatherMeasurement
    {
        /// <summary>
        /// Uses kelvin for temperature and meters for lengths.
        /// </summary>
        public const string Standard = "standard";

        /// <summary>
        /// Uses celsius for temperature and meters for lengths.
        /// </summary>
        public const string Metric = "metric";

        /// <summary>
        /// Uses fahrenheit for temperature and miles for lengths.
        /// </summary>
        public const string Imperial = "imperial";
    }
}