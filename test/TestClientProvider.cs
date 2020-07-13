using System;
using Xunit;
using hacker_news_nextech;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;

namespace test
{
public class TestClientProvider : IDisposable
{
    private TestServer server;
    public HttpClient Client { get; private set; }
    // instance of test server
     public TestClientProvider()
    {
        var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
 
        Client =  server.CreateClient();
    }

        public void Dispose()
        {
            HostBuilderTestSer
        }
    }
}
