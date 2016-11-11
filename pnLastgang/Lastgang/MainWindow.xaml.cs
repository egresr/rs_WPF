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

namespace Lastgang
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


        private void buttonNachtLeuchte_Click(object sender, RoutedEventArgs e)
        {
            Nachtleuchte nachtLeuchte = new Nachtleuchte(60);
            Polyline pLine = new Polyline();

            for (int stunde = 0; stunde < 24; stunde++)
            {
                for (int minute = 0; minute < 60; minute++)
                {
                    double p = nachtLeuchte.BestimmeLeistung(stunde + minute / 60.0);
                    double positionX = (stunde + minute / 60.0) * canvasGrafik.ActualWidth / 24.0;
                    double positionY = (1.0 - p / 10000) * canvasGrafik.ActualHeight;
                    pLine.Points.Add(new Point(positionX, positionY));

                    int stop = 1;
                }
            }

            pLine.Stroke = Brushes.Red;
            pLine.StrokeThickness = 2.0;

            canvasGrafik.Children.Clear();
            canvasGrafik.Children.Add(pLine);


        }

        private void buttonWaschmaschine_Click(object sender, RoutedEventArgs e)
        {
            Polyline pLine = new Polyline();

            Waschmaschine w1 = new Waschmaschine(100, 80);
            Waschmaschine w2 = new Waschmaschine(100, 80);
            Waschmaschine w3 = new Waschmaschine(100, 80);

            for (int stunde = 0; stunde < 24; stunde++)
            {
                for (int minute = 0; minute < 60; minute++)
                {
                    double p = w1.StarteWaschmaschine(stunde + minute / 60.0, 0.5, 1.0);
                    p += w2.StarteWaschmaschine(stunde + minute / 60.0, 0.5, 1.0);
                    p += w3.StarteWaschmaschine(stunde + minute / 60.0, 0.5, 1.0);
                    pLine.Points.Add(new Point(canvasGrafik.ActualWidth * (stunde + minute / 60.0) / 24.0, (1.00 - p / 10000) * canvasGrafik.ActualHeight));
                }
            }

            pLine.Stroke = Brushes.Blue;
            pLine.StrokeThickness = 2.0;

            canvasGrafik.Children.Clear();
            canvasGrafik.Children.Add(pLine);
        }

        private void buttonWaschMasch_100Stk_Click(object sender, RoutedEventArgs e)
        {
            Waschmaschine[] w_100 = new Waschmaschine[10];
            Polyline pline = new Polyline();
            double p = 0.0;

            for (int i = 0; i < w_100.Length; i++)
            {
                w_100[i] = new Waschmaschine(100.0, 60.0);
            }

            for (int stunde = 0; stunde < 24; stunde++)
            {
                for (int minute = 0; minute < 60; minute++)
                {
                    for (int i = 0; i < w_100.Length; i++)
                    {
                        double startZeit = stunde + minute / 60.0;
                        double xAchse = canvasGrafik.ActualWidth * startZeit / 24.0;
                        double yAchse = (1.0 - p / 100000) * canvasGrafik.ActualHeight;

                        p += w_100[i].StarteWaschmaschine(startZeit, 0.5, 1.0);
                        pline.Points.Add(new Point(xAchse, yAchse));
                    }
                }
            }



            pline.Stroke = Brushes.DarkGreen;
            pline.StrokeThickness = 2.0;

            canvasGrafik.Children.Clear();
            canvasGrafik.Children.Add(pline);

        }
    }
}
