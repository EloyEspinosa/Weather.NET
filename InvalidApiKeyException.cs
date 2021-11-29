using System;

namespace Weather.NET
{
    /// <summary>
    /// The exception that is called when an API request fails for an invalid api key.
    /// </summary>
    [Serializable]
    public class InvalidApiKeyException : Exception
    {
        public InvalidApiKeyException() { }
        public InvalidApiKeyException(string message) : base(message) { }
        public InvalidApiKeyException(string message, Exception innerException) : base(message, innerException) { }
    }
}