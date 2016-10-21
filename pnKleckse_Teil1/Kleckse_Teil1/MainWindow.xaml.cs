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
        Random rnd = new Random();


        

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
                    distanz[i][j] = rnd.NextDouble() * 100.0; //jagged Array mit Random Daten fuellen
                }
            }



            string testStopPoint = "###STOP###STOP###STOP###";
        }
    }
}
