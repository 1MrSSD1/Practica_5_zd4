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

namespace WpfApp37
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(Boxa.Text);
            double x = 0;
            double f = 1;
            for (int i = 1; i <= a; i++)
            {
                f *= i;
                x += f;
            }
            txtOtv.Text = $"Сумма факториалов от 1 до {a} = {x}";
        }
    }
}
