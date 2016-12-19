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

namespace RemotelibClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RemoteLibServiceReference.RemotelibServiceSoapClient proxy;
        String filter = "";
        List<string> bookList;

        public MainWindow()
        {
            proxy = new RemoteLibServiceReference.RemotelibServiceSoapClient();
            InitializeComponent();
            //bookList = new List<string>();
            //lvBookList.ItemsSource = bookList;
            RefreshListView();
        }

        private void btAddBook_Click(object sender, RoutedEventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            // Minimalistic input validation
            if ((title == "") || (author == ""))
            {
                MessageBox.Show("Title and author must not be empty");
                return;
            }
            int yop;
            if (!Int32.TryParse(tbYop.Text, out yop))
            {
                MessageBox.Show("Year must be an integer");
                return;
            }
            //
            proxy.AddBook(title, author, yop);
            //Reset the filter 
            filter = "";
            tbFilter.Text = "";
            RefreshListView();
        }
        private void RefreshListView()
        {
            bookList = proxy.GetFilteredBooks(filter);
            lvBookList.ItemsSource = bookList;

        }

        private void tbFilter_KeyUp(object sender, KeyEventArgs e)
        {
            filter = tbFilter.Text;
            RefreshListView();
        }

    }
}
