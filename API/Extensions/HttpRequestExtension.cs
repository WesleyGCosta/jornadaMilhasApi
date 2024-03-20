using Microsoft.AspNetCore.Http;

namespace API.Extensions
{
    public static class HttpRequestExtension
    {
        public static string GetBaseUrl(this HttpRequest httpContext)
        {
            return $"{httpContext?.Scheme}://{httpContext?.Host}";
        }
    }
}
