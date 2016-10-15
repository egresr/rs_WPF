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

namespace Kugel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        int klick = 1;

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += physics;
            timer.Interval = TimeSpan.FromSeconds(0.05);

        }

        private void rBtnRot_Click(object sender, RoutedEventArgs e)
        {
            ball.Fill = Brushes.Red;
        }

        private void rBtnGruen_Click(object sender, RoutedEventArgs e)
        {
            ball.Fill = Brushes.Green;
        }

        private void rBtnBlau_Click(object sender, RoutedEventArgs e)
        {
            ball.Fill = Brushes.Blue;
        }

        private void btnStartStop_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = !timer.IsEnabled;
        }

        bool goingRight = true;
        bool goingDown = true;

        void physics(object sender, EventArgs e)
        {
            double v = 5.0;
            if (chkBxSchnell.IsChecked.Value)
            {
                v = 10;
            }

            //Horizontal****************************************************
            double x = Canvas.GetLeft(ball);

            if (goingRight)
            {
                x += v;
                if (x + ball.Width > theCanvas.ActualWidth)
                {
                    x = theCanvas.ActualWidth - ball.Width;
                    goingRight = false;
                    System.Media.SystemSounds.Asterisk.Play();
                }
            }
            else
            {
                x -= v;
                if (x < 0.0)
                {
                    x = 0;
                    goingRight = true;
                    System.Media.SystemSounds.Asterisk.Play();
                }
            }
            Canvas.SetLeft(ball, x);

            //Vertikal****************************************************
            double y = Canvas.GetTop(ball);
            if (goingDown)
            {
                y += v;
                if (y + ball.Height > theCanvas.ActualHeight)
                {
                    y = theCanvas.ActualHeight - ball.Height;
                    goingDown = false;
                    System.Media.SystemSounds.Hand.Play();
                }
            }
            else
            {
                y -= v;
                if (y < 0.0)
                {
                    y = 0;
                    goingDown = true;
                    System.Media.SystemSounds.Hand.Play();
                }
            }
            Canvas.SetTop(ball, y);
        }

        private void ball_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(timer.IsEnabled)
            {
                lblZaehler.Content = klick;
                klick++;
            }

        }
    }
}
