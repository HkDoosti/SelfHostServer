// See https://aka.ms/new-console-template for more information
using System.Web.Http;
using System.Web.Http.SelfHost;


var config = new HttpSelfHostConfiguration("http://localhost:5009");

config.Routes
    .MapHttpRoute(
    "Default", "api/{controler}/{id}",
    new { id = RouteParameter.Optional });

HttpSelfHostServer server = new HttpSelfHostServer(config);

server.OpenAsync().Wait();

Console.ReadLine();
