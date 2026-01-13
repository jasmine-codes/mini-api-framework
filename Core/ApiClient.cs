using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MiniApiFramework.Core
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(string baseUrl)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new System.Uri(baseUrl);
            };
        }
    }
}