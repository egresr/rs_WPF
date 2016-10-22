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

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double operand1 = 0;
        double operand2 = 0;
        enum Oprtr { Keine, Sum, Dif, Mal, Teil}
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnZiffer_Click(object sender, RoutedEventArgs e)
        {
            EingabeZiffer(sender as Button);
        }

        private void btnOperation_Click(object sender, RoutedEventArgs e)
        {
            EingabeOperation(sender as Button);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtBx.Text = "0";
        }

        private void EingabeZiffer(Button btnNr)
        {
            txtBx.Text += btnNr.Content;
            operand1 = Convert.ToDouble(txtBx.Text);
            lblOperand1.Content = operand1;
        }

        private void EingabeOperation(Button btnNr)
        {
            switch (Oprtr)
            {
                default:
                    break;
            }
        }


    }
}
