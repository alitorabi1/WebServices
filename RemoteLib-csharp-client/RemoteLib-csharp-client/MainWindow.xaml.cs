using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RemoteLib_csharp_client
{
    [XmlRpcUrl("http://127.0.0.1:8181/XmlRpcServlet")]

    public interface ILibrary : IXmlRpcProxy
    {
        [XmlRpcMethod("Library.addBook")]
        int AddBook(String title, String author, int yop);
    }
    public partial class MainWindow : Window
    {
        ILibrary proxy;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            proxy = XmlRpcProxyGen.Create<ILibrary>();
            proxy.AddBook("CSharp", "C. csharp", 2001);

        }
    }
}
