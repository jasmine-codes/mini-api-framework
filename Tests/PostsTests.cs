using MiniApiFramework.Core;
using MiniApiFramework.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniApiFramework.Tests
{
    public class PostsTests : BaseTest
    {
        [Test]
        public async Task Get_All_Posts_Returns_Data()
        {
         var posts = await ApiClient.GetAsync<List<Post>>("/posts");   
        }
    }
}