﻿using System;
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

namespace Meeting
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //8
            MyMeeting m = new MyMeeting();
            MyMeeting m1 = new MyMeeting(23.0);

            if (m.IstAktuell())
            {
                //...
            }

            m.Verschieben(14253);

            //12
            //m.set_Duration(m.get_Druation() + TimeSpan.FromHours(2.0));

            //13
            TimeSpan ts = m.Duration; // Aktuelle Dauer wird geholt
            m.Duration += TimeSpan.FromHours(1.5); // Aktuelle Dauer wird geholt und um 1,5 erhoht





            string stopStop = "+++ STOP +++ STOP +++";
         }
    }
}               
