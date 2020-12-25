using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Threading;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace PC__Cleaner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window    {


      


        public MainWindow()
        {
            InitializeComponent();

            frame.NavigationService.Navigate(new Page1());

            btn.IsChecked = true;

         


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            frame.NavigationService.Navigate(new Page2());

        }

       private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {


            frame.NavigationService.Navigate(new Page1());


        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

           
        }
    }
}
