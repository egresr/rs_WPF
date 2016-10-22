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

namespace Kleckse_Teil1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int numPoints = 10000; //Klecks Anzahl
        double[,] xy = new double[numPoints, 2]; // mehrdimensionale Array fuer Kleks Koordinaten
        double[][] distanz = new double[numPoints][]; // jagged Array fuer Abstaende zwischen Kleks
        Ellipse[] ellipses = new Ellipse[numPoints]; // eindimensionale Array von Typ "Ellipse"
        Brush[] brushes = new Brush[5];


        Random random = new Random();

        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer(); // Timer erzeugen





        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < numPoints; i++)
            {
                distanz[i] = new double[i]; // jagged Array mit leeren eindimensionalen Array's fuellen

                for (int j = 0; j < i; j++)
                {
                    distanz[i][j] = random.NextDouble() * 100.0; //jagged Array mit Random Daten fuellen
                }

                xy[i, 0] = random.NextDouble() + 0.5 * Width;
                xy[i, 1] = random.NextDouble() + 0.5 * Height;

            }

            brushes[0] = Brushes.Red;
            brushes[1] = Brushes.Green;
            brushes[2] = Brushes.Blue;
            brushes[3] = Brushes.Brown;
            brushes[4] = Brushes.Cyan;

            for (int i = 0; i < numPoints; i++) // Kleckse erstellen
            {
                Ellipse myEllipse = new Ellipse();
                myEllipse.Fill = brushes[i % brushes.Length]; //Farbe fuer Kleckse
                myEllipse.Width = 5.0;
                myEllipse.Height = 5.0;
                myCanvas.Children.Add(myEllipse); // Kleckse Ausgabe
                ellipses[i] = myEllipse;
            }

            timer.Interval = TimeSpan.FromSeconds(0.1); // Timer interval
            timer.Tick += layout; // Methode die aufgerufen werden soll !!! += !!! nutzen
            timer.IsEnabled = true; // Timer einschalten

            string testStopPoint = "###STOP###STOP###STOP###";
        }

        void layout(object sender, EventArgs e)
        {
            Ellipse myEllipse = new Ellipse();
            for (int i = 0; i < numPoints; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    double dx = xy[i, 0] - xy[j, 0];
                    double dy = xy[i, 1] - xy[j, 1];

                    double dist = Math.Sqrt(dx * dx + dy * dy);

                    if (dist < distanz[i][j])
                    {
                        xy[i, 0] += dx / dist;
                        xy[i, 1] += dy / dist;

                        xy[j, 0] -= dx / dist;
                        xy[j, 1] -= dy / dist;
                    }
                }
            }

            for (int i = 0; i < numPoints; i++) // Kleckse erstellen
            {
                Canvas.SetLeft(ellipses[i], xy[i, 0]); // Klecks an "Canvas" positionieren
                Canvas.SetTop(ellipses[i], xy[i, 1]); // Klecks an "Canvas" positionieren
            }
        }




    }
}
