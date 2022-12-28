using System.Net;

namespace _0007_multiple_exceptions_filter
{
    class ResultCodeFilter
    {
        public async Task<bool> SomeOperation(HttpClient client)
        {
            bool success = true;

            try
            {
                var response = await client.GetAsync("http://example.com");
            }
            catch(HttpRequestException ex) when (ex.StatusCode.HasValue && ex.StatusCode.Value == HttpStatusCode.NotFound)
            {
                success = false;
            }
            
            return success;
        }
    }
}
