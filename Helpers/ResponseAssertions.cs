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

        public static void AssertStatus (HttpResponseMessage response, int expected)
        {
            Assert.That((int)response.StatusCode, Is.EqualTo(expected));
        }
    }
}