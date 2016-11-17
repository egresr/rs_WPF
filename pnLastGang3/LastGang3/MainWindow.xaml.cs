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

namespace LastGang3
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Verbraucher> verbraucher;
        Nachtleuchter nachtLeuchter;
        LeistungAbfrage leistungAbfrage;
        public MainWindow()
        {
            InitializeComponent();
            verbraucher = new List<Verbraucher>();
            nachtLeuchter = new Nachtleuchter();
            leistungAbfrage = new LeistungAbfrage();

            verbraucher.Add(nachtLeuchter);


        }

        private void buttonAllesAn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonNachtLeuchter_Click(object sender, RoutedEventArgs e)
        {            
            Button button = sender as Button;
            nachtLeuchter.Aktiviere(60, button);
        }

        private void buttonGrafik_Click(object sender, RoutedEventArgs e)
        {
            
            leistungAbfrage.Berechne(nachtLeuchter);
        }
    }
}
