using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Quiz2ServiceReference.Quiz2WebServiceSoapClient proxy;
        List<string> persons;
        String nameSearch = "";
        int minAge = 0;
        int maxAge = 150;
        int minHeight = 0;
        int maxHeight = 250;
        public MainWindow()
        {
            proxy = new Quiz2ServiceReference.Quiz2WebServiceSoapClient();
            InitializeComponent();
            refreshList();
        }

        void refreshList()
        {
            persons = proxy.getPersons(nameSearch, minAge, maxAge, minHeight, maxHeight);
            lstPersonList.ItemsSource = persons;
        }

        private void btAddPerson_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            int age = int.Parse(tbAge.Text);
            int height = int.Parse(tbHeight.Text);
            proxy.addPerson(name, age, height);
            refreshList();
        }

        private void btSearch_Click(object sender, RoutedEventArgs e)
        {
            if (tbNameContains.Text != "") nameSearch = tbNameContains.Text;
            if (tbAgeFrom.Text != "") minAge = int.Parse(tbAgeFrom.Text);
            if (tbAgeTo.Text != "") maxAge = int.Parse(tbAgeTo.Text);
            if (tbHeightFrom.Text != "") minHeight = int.Parse(tbHeightFrom.Text);
            if (tbHeightTo.Text != "") maxHeight = int.Parse(tbHeightTo.Text);
            try
            {
                proxy.getPersons(nameSearch, minAge, maxAge, minHeight, maxHeight);
                refreshList();
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }


    }
}
