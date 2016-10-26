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

namespace SOAPLibClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static LibServiceReference.LibWebServiceSoapClient proxy;
        List<string> list = new List<string>();
        public MainWindow()
        {
            proxy = new LibServiceReference.LibWebServiceSoapClient();
            InitializeComponent();
            list = proxy.GetFilterListOfStrings("");
            lstListBook.ItemsSource = list;
        }

        private void btAddBook_Click(object sender, RoutedEventArgs e)
        {
            proxy = new LibServiceReference.LibWebServiceSoapClient();
            InitializeComponent();
            list = proxy.AddBook(tbTitle.Text, tbTitle.Text, int.Parse(tbYop.Text));
            lstListBook.ItemsSource = list;
        }

        void refreshList(string keyword)
        {
            list = proxy.GetALLBooks(keyword);
            lstListBook.ItemsSource = list;
        }

        private void tbFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            refreshList(tbFilter.Text);
        }
    }
}
