using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiniApiFramework.Helpers
{
    public static class TestLogger
    {
        public static async Task LogResponse(HttpResponseMessage response)
        {
            Console.WriteLine($"STATUS: {(int)response.StatusCode}");
            Console.WriteLine("BODY:");
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            Console.WriteLine("---------------------------");
        }
    }
}