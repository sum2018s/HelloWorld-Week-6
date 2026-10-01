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

namespace MyRPG_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object lblMessage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnpress_Click(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "Hello RPG Game: " + player;
        }
    }
}
