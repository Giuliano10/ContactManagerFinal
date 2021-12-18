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
using System.Windows.Shapes;

namespace ContactManagerFinal
{
    /// <summary>
    /// Interaction logic for AddContactWindow.xaml
    /// </summary>
    public partial class AddContactWindow : Window
    {

        public AddContactWindow()
        {
            InitializeComponent();

        //AddContactLabel.Content = txt;
        }

        private void AddWindowCloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
