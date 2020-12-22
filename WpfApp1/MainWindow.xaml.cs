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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float number1 = 0;
        float number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtdisplay.Text == "0"  )
                txtdisplay.Text = "";

            if((sender as Button).Content.ToString() == ".")
            {
                if(txtdisplay.Text == "")
                {
                    txtdisplay.Text = "0";
                    return;
                }

                if (!txtdisplay.Text.Contains('.'))
                    txtdisplay.Text += (sender as Button).Content.ToString();
            }
            else
            {
                txtdisplay.Text +=  (sender as Button).Content.ToString() ;

            }

          




        }

        private void operationBtn_Click(object sender, RoutedEventArgs e)
        {

            if(txtdisplay.Text == "0" || txtdisplay.Text == "" || operation != "")
            {
                return ;
            }

            number1 = float.Parse(txtdisplay.Text);
            operation = (sender as Button).Content.ToString();
            txtdisplay.Text = "0";
            display.Text = number1.ToString() + operation;


        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {


            if (txtdisplay.Text == "0" || txtdisplay.Text == "" || operation == "" )
            {
                return;
            }

            number2 = float.Parse(txtdisplay.Text);

            display.Text +=  number2.ToString() + "=" ;



            switch (operation)
            {
                case "+":
                    {
                        txtdisplay.Text =  (number1 + number2).ToString() ;
                        break;
                    }
                case "-":
                    {
                        txtdisplay.Text = (number1 - number2).ToString();
                        break;
                    }
                case "*":
                    {
                        txtdisplay.Text = (number1 * number2).ToString();
                        break;
                    }
                case "/":
                    {
                        txtdisplay.Text = (number1 / number2).ToString();
                        break;
                    }
            
                default:
                    txtdisplay.Text =  ("the action is wrong try again  ");
                    break;
            }

            operation = "";


        }

        private void btnPositiveNegetive_Click(object sender, RoutedEventArgs e)
        {

            if (txtdisplay.Text != "" && txtdisplay.Text != "0")

            {

               

                if( txtdisplay.Text[0].Equals('-') ){

                    
                  txtdisplay.Text =   txtdisplay.Text.Replace( "-" , "" );

                }
                else
                {
                    txtdisplay.Text = "-" + txtdisplay.Text;

                }


                

            }


               

        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtdisplay.Text != "" && txtdisplay.Text != "0")

            {

                txtdisplay.Text = txtdisplay.Text.Remove(txtdisplay.Text.Length - 1);

                if(txtdisplay.Text == "")
                    txtdisplay.Text = "0";



            }


        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 = 0;
                number2 = 0;
                operation = "";
                display.Text = "";

            }

            txtdisplay.Text = "0";

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

            txtdisplay.Text = "0";
            number1 = 0;
            number2 = 0;
            operation = "";
            display.Text = "";


        }


       








    }
}
