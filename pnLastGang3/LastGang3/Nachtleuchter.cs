using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace LastGang3
{
    internal class Nachtleuchter : Verbraucher
    {
        private double leistungWatt;

        static List<DateTime> listZeitON = new List<DateTime>();
        static List<DateTime> listZeitOFF = new List<DateTime>();
        static bool aktiviert = false;

        public bool Aktiviert
        {
            get { return aktiviert; }
        }

        public List<DateTime> ListZeitON
        {
            get { return listZeitON; }
        }

        public List<DateTime> ListZeitOFF
        {
            get { return ListZeitOFF; }
        }

        public double Leistung { get; }

        public void Aktiviere(double leistungWatt, Button btn)
        {
            this.leistungWatt = leistungWatt;
            aktiviert = !aktiviert;

            if (aktiviert)
            {
                HinzufuegeZeitON();
            }
            else if (!aktiviert)
            {
                HinzufuegeZeitOFF();
            }

            AendereButtonContent(btn);
            AendereButtonFarbe(btn);
        }

        void AendereButtonContent(Button btn)
        {
            if (aktiviert)
            {
                btn.Content = "ON";
            }
            else
            {
                btn.Content = "OFF";
            }
        }

        void AendereButtonFarbe(Button btn)
        {
            if (aktiviert)
                btn.Background = Brushes.LawnGreen;
            else
                btn.Background = Brushes.Yellow;

        }

        void HinzufuegeZeitON()
        {
            listZeitON.Add(DateTime.Now);
        }

        void HinzufuegeZeitOFF()
        {
            listZeitOFF.Add(DateTime.Now);
        }
    }
}