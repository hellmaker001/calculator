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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value = 0;
        string operation="";
        bool opr_clicked = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((Result.Text == "0") || (opr_clicked))
            {   
                Result.Text="";
                opr_clicked = false;
            }

            Button b = (Button)sender;
            if(b.Content.ToString() == ".")
            {
                if (!Result.Text.Contains("."))
                    Result.Text = Result.Text + b.Content;
            }
            else
                Result.Text = Result.Text + b.Content;

        }

        private void operator_click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Content.ToString();
            value = Double.Parse(Result.Text);
            opr_clicked = true;


        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+": Result.Text = (value + double.Parse(Result.Text)).ToString();
                    break;

                case "-": Result.Text = (value - double.Parse(Result.Text)).ToString();
                    break;

                case "/": Result.Text = (value / double.Parse(Result.Text)).ToString();
                    break;

                case "*": Result.Text = (value * double.Parse(Result.Text)).ToString();
                    break;
                

                default: break;
            }
            opr_clicked = true;
            
        }

        private void Button_Click_c(object sender, RoutedEventArgs e)
        {
            Result.Text = "0";
            value = 0;
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            value = Double.Parse(Result.Text);
            Result.Text = Math.Sqrt(value).ToString();
            opr_clicked = true;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            value = Double.Parse(Result.Text);
            Result.Text = (value / 100).ToString();
            opr_clicked = true;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            value = Double.Parse(Result.Text);
            Result.Text = (1 / value).ToString();
            opr_clicked = true;
        }

       
    }
}
