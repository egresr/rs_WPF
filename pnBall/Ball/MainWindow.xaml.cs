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

namespace Ball
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

        double vX = 1000.0; //geschwindigkeit X- Richtung --- Es sollte 3 Pixel in bestimmte Zeit Horizontal verlegt werden.
        double vY = 500.0; //geschwindigkeit Y- Richtung --- Es sollte 3 Pixel in bestimmte Zeit Vertikal verlegt werden.

        public MainWindow()
        {
            InitializeComponent();
            
            //Timer
            timer.Interval = TimeSpan.FromSeconds(0.005); //stellt Timerinterval
            timer.IsEnabled = true; //eingeschaltet
            timer.Tick += animate;  //ruft Function auf
        }

        void animate(object sender, EventArgs e)
        {
            double ballPositionX = Canvas.GetLeft(ball);
            double ballPositionY = Canvas.GetTop(ball);
            double breiteCanvas = myCanvas.ActualWidth;
            double hoheCanvas = myCanvas.ActualHeight;


            lblBallKoordinateX.Content = ballPositionX;
            lblBallKoordinateY.Content = ballPositionY;

            //
            //Bewegung Horizontal
            //
            //Horizontale Koordinaten bestimmen
            ballPositionX += vX * timer.Interval.TotalSeconds;
            //Horizontale Richtung ueberwachen
            if (ballPositionX <= 0.0 || ballPositionX + ball.Width >= breiteCanvas)
            {
                vX *= -1;
            }
            //Neue horizontale Position setzen
            Canvas.SetLeft(ball, ballPositionX);

            //
            //Bewegung Vertikal
            //
            //Vertikale Koordinate bestimmen
            ballPositionY += vY * timer.Interval.TotalSeconds;
            //Vertikale Richtung ueberwachen
            if (ballPositionY <= 0.0 || ballPositionY + ball.Height >= hoheCanvas)
            {
                vY *= -1;
            }
            //Neu vertikale Position setzen
            Canvas.SetTop(ball, ballPositionY);
        }
    }
}
