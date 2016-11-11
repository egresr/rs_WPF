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

namespace LastGang1
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

        private void buttonLast_Click(object sender, RoutedEventArgs e)
        {
            Polyline pLineLeistung = new Polyline();

            double zeit;
            double leistung;
            int yAchseMaxWert = 1000;

            double kochZeit = 0.5;
            double schleuderZeit = 1.0;
            double kochLeistung = 2000;
            double schleuderLeistung = 6000;

            Nachtleuchte nl = new Nachtleuchte(60.0);
            Waschmaschine w1 = new Waschmaschine( kochZeit, schleuderZeit, kochLeistung, schleuderLeistung);
            Waschmaschine w2 = new Waschmaschine(kochZeit, schleuderZeit, kochLeistung, schleuderLeistung);
            for (int stunde = 0; stunde < 24; stunde++)
            {
                for (int minute = 0; minute < 60; minute++)
                {
                    zeit = stunde + minute / 60.0;
                    //leistung = nl.Starte(zeit);
                    leistung = w1.Starte(zeit);
                    leistung = w2.Starte(zeit);

                    double xAchse = zeit * canvasGrafik.ActualWidth / 24;
                    double yAchse = (1 - leistung / yAchseMaxWert) * canvasGrafik.ActualHeight;

                    pLineLeistung.Points.Add(new Point(xAchse, yAchse));
                }
            }



            pLineLeistung.Stroke = Brushes.Red;
            pLineLeistung.StrokeThickness = 2;

            canvasGrafik.Children.Add(pLineLeistung);

        }
    }
}
