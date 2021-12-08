namespace Weather.NET
{
    /// <summary>
    /// Contains constants for all available map layers for weather maps.
    /// </summary>
    public static class MapLayer
    {
        /// <summary>
        /// Gets a layer map of the cloud percentage (%) of the area.
        /// </summary>
        public const string Clouds = "clouds_new";

        /// <summary>
        /// Gets a layer map of the rain volume (mm) of the area.
        /// </summary>
        public const string Precipitation = "precipitation_new";

        /// <summary>
        /// Gets a layer map of the sea level pressure (Pa) of the area.
        /// </summary>
        public const string Pressure = "pressure_new";

        /// <summary>
        /// Gets a layer map of wind speed (m/s) of the area.
        /// </summary>
        public const string WindSpeed = "wind_new";

        /// <summary>
        /// Gets a layer map of temperature (Celsius) of the area.
        /// </summary>
        public const string Temperature = "temp_new";
    }
}