namespace Weather.NET.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a http request ends in a 404 Not Found error.
    /// </summary>
    public class HttpNotFoundException : Exception
    {
        public HttpNotFoundException() { }
        public HttpNotFoundException(string message) : base(message) { }
        public HttpNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}