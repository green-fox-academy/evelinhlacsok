using System;
using Xunit;
using System.Net.Http;
using RedditApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Threading.Tasks;
using System.Net;

namespace IntegrationTesting
{
    public class ApiTest
    {

        private readonly TestServer Server;
        private readonly HttpClient Client;

        public ApiTest()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnWithOkStatus()
        {
           // Assert.True(false);
            var response = await Client.GetAsync("/posts");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
