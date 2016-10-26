using AcspNet;
using AcspNet.Attributes;
using AcspNet.Responses;

namespace CSharpSOAPLibServer.Controllers
{
    [Get("/")]
    public class DefaultController : Controller
    {
        public override ControllerResponse Invoke()
        {
            return new MessageBox("Hello world!");
        }
    }
}
