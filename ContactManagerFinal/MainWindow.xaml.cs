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

            List<ToDoItem> items = new List<ToDoItem>();


            items.Add(new ToDoItem("C# Test", 10));
            items.Add(new ToDoItem("C# Project", 2));
            items.Add(new ToDoItem("SQL Practice Question", 80));
            items.Add(new ToDoItem("SQL Final", 4));


            LbToDoList.ItemsSource = items;
            LbToDoList.SelectedIndex = 0;
            LbToDoList.Focus();





        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {



        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowSelectAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LbToDoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnWindow_Click(object sender, RoutedEventArgs e)
        {

            ExampleNewWIndow eWIndow = new ExampleNewWIndow("Hey Bello");
            eWIndow.Show();

        }
    }
}
