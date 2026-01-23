using MiniApiFramework.Core;
using MiniApiFramework.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime;
using System.Threading.Tasks;

namespace MiniApiFramework.Tests
{
    public class PostsTests : BaseTest
    {
        [Test]
        public async Task Get_All_Posts_Returns_Data()
        {
         var posts = await ApiClient.GetAsync<List<Post>>("/posts");

         Assert.That(posts, Is.Not.Null);
         Assert.That(posts!.Count, Is.GreaterThan(0));
         Assert.That(posts[0].Title, Is.Not.Empty);
        }

        [Test]
        public async Task Create_Post_Returns_201()
        {
            var newPost = new CreatePostRequest
            {
                UserId = 1,
                Title = "Hello QA World",
                Body = "Testing APIs is fun"
            };

            var response = await ApiClient.PostAsync("/posts", newPost);

            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.Created));
        }

        [Test]
        public async Task Get_Invalid_Post_Returns_404()
        {
            var response = await ApiClient.GetAsync("/posts/999999");
            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.NotFound));
        }
    }
}