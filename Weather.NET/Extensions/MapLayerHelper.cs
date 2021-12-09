namespace Weather.NET.Extensions
{
    internal static class MapLayerHelper
    {
        private static readonly string[] maps = {
            "temp_new", "clouds_new", "precipitation_new", "pressure_new", "wind_new", "snow_new"
        };

        internal static string Convert(this MapLayer layer) => maps[(int) layer];
    }
}