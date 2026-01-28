using System.Net.Http;
using NUnit.Framework;

namespace MiniApiFramework.Helpers
{
    public static class ResponseAssertions
    {
        public static void AssertSuccess(HttpResponseMessage response)
        {
            Assert.That(response.IsSuccessStatusCode, Is.True,
            $"Expected success but got {response.StatusCode}");
        }
    }
}