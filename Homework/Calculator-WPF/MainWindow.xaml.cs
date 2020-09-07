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

namespace Calculator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputOper_OnDataContextChanged(object sender, EventArgs e)
        {
            char data = InputOper.Text.Length > 0 ? InputOper.Text[0] : '+';

            switch (data)
            {
                case '+': return;
                case '-': return;
                case '*': return;
                case '/': return;
            }

            data = '+';

            InputOper.Text = "" + data;
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            InputA.Text = "1";
            InputB.Text = "2";
            InputOper.Text = "+";

            InputOper.TextChanged += InputOper_OnDataContextChanged;

            InputA.TextChanged += Calculate;
            InputB.TextChanged += Calculate;
            InputOper.TextChanged += Calculate;
        }

        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(InputA.Text);
                double b = Double.Parse(InputB.Text);
                char oper = InputOper.Text[0];
                double result = 0;

                switch (oper)
                {
                    case '+':
                        {
                            result = a + b;
                            break;
                        }
                    case '-':
                        {
                            result = a - b;
                            break;
                        }
                    case '*':
                        {
                            result = a * b;
                            break;
                        }
                    case '/':
                        {
                            result = a / b;
                            break;
                        }
                }

                InputResult.Text = "" + result;
            }
            catch (Exception exception)
            {
                
            }
        }
    }
}
