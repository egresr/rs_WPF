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
            TimeSpan? timeSpanVoll = klndrStartDatum.SelectedDate - DateTime.Now;//Gibt Datum und Uhrzeit

            TimeSpan? timeSpanDatum = klndrStartDatum.SelectedDate - DateTime.Today;//Gibt nur Datum

            lblSekunden.Content = timeSpanVoll.Value.Seconds;
            lblTotalSekunden.Content = timeSpanVoll.Value.TotalSeconds;

            lblMinuten.Content = timeSpanVoll.Value.Minutes;
            lblTotalMinuten.Content = timeSpanVoll.Value.TotalMinutes;

            lblStunden.Content = timeSpanVoll.Value.Hours;
            lblTotalStunden.Content = timeSpanVoll.Value.TotalHours;

            lblTagen.Content = timeSpanDatum.Value.Days;
            lblTotalTagen.Content = timeSpanVoll.Value.TotalDays;
        }
    }
}
