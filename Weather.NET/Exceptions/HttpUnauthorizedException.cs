namespace Weather.NET.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a http request ends in a 401 Unauthorized error.
    /// </summary>
    public class HttpUnauthorizedException : Exception
    {
        public HttpUnauthorizedException() { }
        public HttpUnauthorizedException(string message) : base(message) { }
        public HttpUnauthorizedException(string message, Exception inner) : base(message, inner) { }
    }
}