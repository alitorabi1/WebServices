using AcspNet.Owin;
using Owin;

namespace CSharpSOAPLibServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseAcspNet();
        }
    }
}