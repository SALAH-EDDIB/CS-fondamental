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
using System.IO;

namespace PC__Cleaner
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

            var mw = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;

            mw.btn2.IsChecked = true ;

            List<string> lines =   File.ReadAllLines(@"C:\Users\youcode\source\repos\helloWord\PC__Cleaner\historique.txt").ToList();

            lines.Reverse();


            foreach(var line in lines)
            {

                Style style = new Style(typeof(TextBlock));
                style.Setters.Add(new Setter(TextBlock.FontSizeProperty ,  25D  ));
                style.Setters.Add(new Setter(TextBlock.ForegroundProperty , Brushes.Gray ));
                style.Setters.Add(new Setter(TextBlock.MarginProperty , new Thickness(5)));
                

                StackPanel[] name = { action, date, time };
                string[] entries = line.Split(',');

                for (var i = 0; i < entries.Length ; i++)
                {
                    TextBlock text = new TextBlock();
                    text.Text = entries[i].Replace('/' , '.');
                    text.Style = style;
                    name[i].Children.Add(text);

                }


                


            }


        }
    }
}
