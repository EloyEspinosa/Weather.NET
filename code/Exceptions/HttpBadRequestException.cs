namespace Weather.NET.Exceptions;

/// <summary>
/// The exception that is thrown when a http request ends in a 400 Bad Request error.
/// </summary>
public class HttpBadRequestException : Exception
{
    public HttpBadRequestException() : base() { }
    public HttpBadRequestException(string message) : base() { }
    public HttpBadRequestException(string message, Exception inner) : base(message, inner) { }
}