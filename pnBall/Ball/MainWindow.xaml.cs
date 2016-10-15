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

        public MainWindow()
        {
            InitializeComponent();
            
            //Timer
            timer.Interval = TimeSpan.FromSeconds(0.05); //stellt Timerinterval
            timer.IsEnabled = true; //eingeschaltet
            timer.Tick += animate;  //ruft Function auf

        }

        bool fliegtNachRechts = true;
        bool fliegtNachUnten = true;
        void animate(object sender, EventArgs e)
        {
            double ballPositionX = Canvas.GetLeft(ball);
            double ballPosistionY = Canvas.GetTop(ball);
            double breiteCanvas = myCanvas.ActualWidth;
            double hoheCanvas = myCanvas.ActualHeight;


            lblBallKoordinateX.Content = ballPositionX;
            lblBallKoordinateY.Content = ballPosistionY;

            //Horizontale bewegung
            if(fliegtNachRechts)
            {
                ballPositionX += 5.0;
            }
            else if(!fliegtNachRechts)
            {
                ballPositionX -= 5.0;
            }

            //Horizontale Richtung ueberwachen
            if (ballPositionX + ball.Width > breiteCanvas)
            {                
                ballPositionX = breiteCanvas - ball.Width;
                fliegtNachRechts = !fliegtNachRechts;
            }
            else if (ballPositionX < 0)
            {
                ballPositionX = 0;
                fliegtNachRechts = !fliegtNachRechts;
            }

            Canvas.SetLeft(ball, ballPositionX);

            //Vertikale bewegung
            if (fliegtNachUnten)
            {
                ballPosistionY += 5.0;
            }
            else if (!fliegtNachUnten)
            {
                ballPosistionY -= 5.0;
            }

            //Vertikale Richtung ueberwachen

            if(ballPosistionY + ball.Height > myCanvas.ActualHeight)
            {
                ballPosistionY = hoheCanvas - ball.Height;
                fliegtNachUnten = !fliegtNachUnten;
            }
            else if (ballPosistionY < 0)
            {
                ballPosistionY = 0;
                fliegtNachUnten = !fliegtNachUnten;
            }

            Canvas.SetTop(ball, ballPosistionY);
        }
    }
}
