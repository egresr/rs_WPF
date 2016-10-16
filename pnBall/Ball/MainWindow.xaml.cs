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

        double vX = 500.00; //geschwindigkeit X- Richtung --- Es sollte 3 Pixel in bestimmte Zeit Horizontal verlegt werden.
        double vY = 500.0; //geschwindigkeit Y- Richtung --- Es sollte 3 Pixel in bestimmte Zeit Vertikal verlegt werden.
        Point p;

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

            //
            //Baal Koordinaten Display
            //
            lblBallKoordinateX.Content = ballPositionX;
            lblBallKoordinateY.Content = ballPositionY;

            //
            //Ball Bewegung Horizontal
            //            
            if (ballPositionX <= 0.0 + schlaegerLinks.ActualWidth || ballPositionX >= breiteCanvas - ball.Width - schlaegerRechts.ActualWidth)//Ball horizontale Richtung ueberwachen
            {
                vX *= -1;
            }            
            ballPositionX += vX * timer.Interval.TotalSeconds;//Ball neue horizontale Koordinaten ausrechnen            
            Canvas.SetLeft(ball, ballPositionX);//Ball neue horizontale Position setzen

            //
            //Ball Bewegung Vertikal
            //           
            ballPositionY += vY * timer.Interval.TotalSeconds; //Ball neue vertikale Koordinaten ausrechnen            
            if (ballPositionY <= 0.0 || ballPositionY + ball.Height >= hoheCanvas)//Vertikale Richtung ueberwachen
            {
                vY = -vY;
            }            
            Canvas.SetTop(ball, ballPositionY);//Ball neue vertikale Position setzen
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            //
            //Maus Koordinaten Display
            //
            p = e.GetPosition(this);
            lblMausX.Content = p.X;
            lblMausY.Content = p.Y;

            Canvas.SetTop(schlaegerLinks, p.Y - schlaegerLinks.Height / 2);
            Canvas.SetTop(schlaegerRechts, p.Y - schlaegerRechts.Height / 2);
        }
    }
}
