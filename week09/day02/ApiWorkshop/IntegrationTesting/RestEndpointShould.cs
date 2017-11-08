using System;
using System.Net.Http;
using ApiWorkshop;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace IntegrationTesting
{
    public class UnitTest1
    {
        private TestServer Server;
        private HttpClient Client;

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
