using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathServiceClient
{
    class Program
    {
        static MathServiceClient.MathServiceReference.MathServiceSoapClient proxy;
        static void Main(string[] args)
        {
            proxy = new MathServiceReference.MathServiceSoapClient();
            Console.WriteLine(" 5 + 7 = {0}", proxy.Add(5, 7));
            Console.ReadKey();
        }
    }
}
