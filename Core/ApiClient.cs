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
                BaseAddress = new System.Uri(baseUrl)
            };
        }

        public async Task<HttpResponseMessage> GetAsync(string endpoint)
        {
            return await _httpClient.GetAsync(endpoint);
        }

        public async Task<T?> GetAsync<T>(string endpoint)
        {
            return await _httpClient.GetFromJsonAsync<T>(endpoint);
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string endpoint, T body)
        {
            return await _httpClient.PostAsJsonAsync(endpoint, body);
        }
    }
}