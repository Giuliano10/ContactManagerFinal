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

namespace ContactManagerFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //List<Contact> contacts = new List<Contact>();


            //contacts.Add(new Contact(1, "Luigi", "Migiliara", "514-010-0101", "lumig@gmail.com"));
            //contacts.Add(new Contact(2, "Giuliano", "Iantomasi", "514-010-0101", "giantomasi@gmail.com"));
            //contacts.Add(new Contact(3, "Matthew", "Noce", "514-010-0101", "mnoce@gmail.com"));


            //LbContactManager.ItemsSource = contacts;
            //LbContactManager.SelectedIndex = 0;
            //LbContactManager.Focus();





        }

        private void btnAddContact_Click(object sender, RoutedEventArgs e)
        {

        //AddContactWindow aWindow = new AddContactWindow();
            
        //    aWindow.Show();

        }

        private void btnUpdateContact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGetContact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteContact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            //DBUtil db = new DBUtil();
            //db.GetContactList();

        }

        private void btnWindow_Click(object sender, RoutedEventArgs e)
        {

            ExampleWindow eWIndow = new ExampleWindow("Hey Bello");
            eWIndow.Show();

        }

        private void LbContactManager_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



        }




    }
}
