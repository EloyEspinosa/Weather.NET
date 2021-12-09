namespace Weather.NET.Exceptions
{
    /// <summary>
    /// The exception that is thrown when a http request ends in a 429 Too Many Requests error.
    /// </summary>
    public class HttpTooManyRequestsException : Exception
    {
        public HttpTooManyRequestsException() { }
        public HttpTooManyRequestsException(string message) : base(message) { }
        public HttpTooManyRequestsException(string message, Exception inner) : base(message, inner) { }
    }
}