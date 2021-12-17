namespace Weather.NET.Extensions;

internal static class LanguageHelper
{
    private static readonly string[] languages =
    {
        "af", "al", "ar", "az", "bg", "ca", "cz", "da", "de", "el", "en", "eu",
        "fa", "fa", "fi", "fr", "gl", "he", "hi", "hr", "hu", "id", "it", "ja",
        "kr", "la", "lt", "mk", "no", "nl", "pl", "pt", "pt_br", "ro", "ru",
        "sv", "sk", "sl", "es", "sr", "th", "tr", "ua", "vi", "zh_cn", "zh_tw", "zu"
    };

    internal static string Convert(this Language lang) => languages[(int)lang];
}