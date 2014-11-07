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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a = 0, b = 0, result = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(tbxInput1.Text);
            b = Convert.ToInt32(tbxInput2.Text);
            result = a - b;
            tbkResult.Text = Convert.ToString(result);

        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(tbxInput1.Text);
            b = Convert.ToInt32(tbxInput2.Text);
            result = a + b;
            tbkResult.Text = Convert.ToString(result);
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(tbxInput1.Text);
            b = Convert.ToInt32(tbxInput2.Text);
            result = a / b;
            tbkResult.Text = Convert.ToString(result);
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(tbxInput1.Text);
            b = Convert.ToInt32(tbxInput2.Text);
            result = a * b;
            tbkResult.Text = Convert.ToString(result);
        }
    }
}
