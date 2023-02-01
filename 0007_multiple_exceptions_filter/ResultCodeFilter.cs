using System.Net;

namespace _0007_multiple_exceptions_filter
{
    static class ResultCodeFilter
    {
        public static async Task<bool> SomeOperationAsync(HttpClient client)
        {
            bool success = true;

            try
            {
                HttpResponseMessage response = await client.GetAsync("http://example.com");
            }
            catch(HttpRequestException ex) when (ex.StatusCode.HasValue && ex.StatusCode.Value == HttpStatusCode.NotFound)
            {
                success = false;
            }

            return success;
        }
    }
}
