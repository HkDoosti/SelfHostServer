
using System;
using System.Web.Http;
using System.Web.Http.SelfHost;
namespace SelfHostServer2.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = 
                new HttpSelfHostConfiguration("http://localhost:5009");

            config.Routes
                .MapHttpRoute(
                "Default",
                "api/{controler}/{id}",
                new { id = RouteParameter.Optional }
                );

            HttpSelfHostServer server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();

            Console.ReadLine();

        }
    }
}
