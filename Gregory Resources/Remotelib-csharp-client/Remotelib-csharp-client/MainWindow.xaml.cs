﻿using System;
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
using CookComputing.XmlRpc;




namespace Remotelib_csharp_client
{
    [XmlRpcUrl("http://127.0.0.1:8282/XmlRpcServlet")]
    public interface ILibrary : IXmlRpcProxy
    {
        [XmlRpcMethod("Remotelibrary.addBook")]
        int AddBook(String title, String author, int yop);
        //    public ArrayList<String> getFilteredBooks(String keyword) throws IOException;
    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ILibrary proxy;

        public MainWindow()
        {
            InitializeComponent();
            proxy = XmlRpcProxyGen.Create<ILibrary>();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {           
            proxy.AddBook("CSharp", "C. Sharp", 2000);
        }
    }
}
