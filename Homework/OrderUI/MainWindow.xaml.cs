using OrderLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace OrderUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private OrderService Service = new OrderService();


        public MainWindow()
        {
            InitializeComponent();

            Service.Add(new Order("XLX", "DZY", 10));
            Service.Add(new Order("XLX", "DZY", 11));
            Service.Add(new Order("XLX", "DZY", 12));
            Service.Add(new Order("XLX", "DZY", 13));
            Service.Add(new Order("WZY", "LYX", Decimal.Parse("8.88")));


            OrderData.ItemsSource = Service.GetOrigionalList();
        }

        private void InputAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Service.Add(new Order(InputItemName.Text, InputCustom.Text, Decimal.Parse(InputBalance.Text)));
            }
            catch (Exception exception)
            { 
                // TODO 日后再说
            }

            
        }
    }
}
