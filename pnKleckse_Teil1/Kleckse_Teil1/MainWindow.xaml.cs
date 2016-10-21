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
        const int numPoints = 5; //Klecks Anzahl
        double[,] xy = new double[numPoints, 2]; // mehrdimensionale Array fuer Kleks Koordinaten
        double[][] distanz = new double[numPoints][]; // jagged Array fuer Abstaende zwischen Kleks
        Ellipse[] ellipses = new Ellipse[numPoints]; // eindimensionale Array von Typ "Ellipse"

        Random random = new Random();

        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer(); // Timer erzeugen





        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < numPoints; i++)
            {
                distanz[i] = new double [i]; // jagged Array mit leeren eindimensionalen Array's fuellen
            }

            for (int i = 0; i < distanz.Length; i++) 
            {
                for (int j = 0; j < distanz[i].Length; j++)
                {
                    distanz[i][j] = random.NextDouble() * 100.0; //jagged Array mit Random Daten fuellen
                }
            }

            for (int i = 0; i < numPoints; i++) // Kleckse erstellen
            {
                Ellipse myEllipse = new Ellipse();
                myEllipse.Fill = Brushes.Blue; //Farbe fuer Kleckse
                myEllipse.Width = 10.0;
                myEllipse.Height = 10.0;
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
                xy[i, 0] += 5 * random.NextDouble(); // neue Random x- Koordinate
                xy[i, 1] += 5 * random.NextDouble(); // neue Random y- Koordinate
            }

            for (int i = 0; i < numPoints; i++) // Kleckse erstellen
            {
                Canvas.SetLeft(ellipses[i], xy[i, 0]); // Klecks an "Canvas" positionieren
                Canvas.SetTop(ellipses[i], xy[i, 1]); // Klecks an "Canvas" positionieren
            }
        }
    }
}
