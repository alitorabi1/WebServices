using Microsoft.Owin.Hosting;

namespace CSharpSOAPLibServer
{
    public class WebApplicationStartup
    {
        public void Run()
        {
            WebApp.Start<Startup>("http://+:8080");
        }
    }
}