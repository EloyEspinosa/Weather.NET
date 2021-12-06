namespace Weather.NET
{
    /// <summary>
    /// Provides a generic OpenWeatherMap weather response.
    /// </summary>
    public struct Weather
    {
        /// <summary>
        /// The name of the city analyzed.
        /// </summary>
        public string CityName { get; internal set; }

        /// <summary>
        /// The OpenWeatherMap city id of the city analyzed.
        /// More information in https://openweathermap.org/current#cityid.
        /// </summary>
        public long CityId { get; internal set; }

        /// <summary>
        /// The longitude of the location analyzed.
        /// </summary>
        public double LocationLongitude { get; internal set; }

        /// <summary>
        /// The latitude of the location analyzed.
        /// </summary>
        public double LocationLatitude { get; internal set; }

        /// <summary>
        /// An english word describing the current weather.
        /// </summary>
        public string Title { get; internal set; }

        /// <summary>
        /// A small description of the current weather in the specified language.
        /// </summary>
        public string Description { get; internal set; }

        /// <summary>
        /// The temperature in the described measurement system.
        /// </summary>
        public double Temperature { get; internal set; }

        /// <summary>
        /// The atmopheric pressure represented in hPa.
        /// </summary>
        public int AtmosphericPressure { get; internal set; }

        /// <summary>
        /// The humidity of the location (%).
        /// </summary>
        public int HumidityPercentage { get; internal set; }

        /// <summary>
        /// The speed of the wind. Depends on the system of measurement.
        /// </summary>
        public double WindSpeed { get; internal set; }

        /// <summary>
        /// The direction of the wind in meteorological degrees.
        /// </summary>
        public int WindDirection { get; internal set; }

        /// <summary>
        /// The cloudiness percentage of the location (%).
        /// </summary>
        public int CloudPercentage { get; internal set; }
    }
}