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

namespace Kalender
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hallo!");
        }

        private void datumGeaendert(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan? timeSpan = klndrStartDatum.SelectedDate - DateTime.Today;

            lblSekunden.Content = timeSpan.Value.TotalSeconds;
            lblMinuten.Content = timeSpan.Value.TotalMinutes;
            lblStunden.Content = timeSpan.Value.TotalHours;
            lblTagen.Content = timeSpan.Value.Days;
        }
    }
}
