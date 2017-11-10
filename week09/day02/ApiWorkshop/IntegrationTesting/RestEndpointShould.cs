using System;
using System.Net.Http;
using ApiWorkshop;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;
using System.Threading.Tasks;
using System.Net;

namespace IntegrationTesting
{
    public class RestEndpointShould
    {
        private TestServer Server;
        private HttpClient Client;

        public RestEndpointShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }
        [Fact]
        public async Task ReturnOkStatusDoubling()
        {
            var response = await Client.GetAsync("/doubling");

           Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Return30to15Doubling()
        {
            var response = await Client.GetAsync("doubling?input=15");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":15,\"result\":30}", responseJson);
        }

        [Fact]
        public async Task NoInputDoubling()
        {
            var response = await Client.GetAsync("doubling");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide an input!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnOkStatusGreeter()
        {
            var response = await Client.GetAsync("/greeter");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusArray()
        {
            var response = await Client.GetAsync("/array");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
