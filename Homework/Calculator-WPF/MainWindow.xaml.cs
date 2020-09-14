using System;
using System.Windows;

namespace Calculator_WPF
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputOper_OnDataContextChanged(object sender, EventArgs e)
        {
            var data = InputOper.Text.Length > 0 ? InputOper.Text[0] : '+';

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
                var a = double.Parse(InputA.Text);
                var b = double.Parse(InputB.Text);
                var oper = InputOper.Text[0];
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