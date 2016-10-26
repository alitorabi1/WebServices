using System.ComponentModel;
using System.Reflection;
using Simplify.AutomatedWindowsServices;

namespace CSharpSOAPLibServer
{
    [RunInstaller(true)]
    public class ServiceInstaller : ServiceInstallerBase
    {
        public ServiceInstaller()
            : base(Assembly.GetExecutingAssembly())
        {
        }
    }
}
