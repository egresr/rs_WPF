using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastGang1
{
    class Waschmaschine
    {
        private double kochLeistung;
        private double kochZeit;
        private double schleuderLeistung;
        private double schleuderZeit;
        private double waschZeitMin = 14.0;
        private double waschZeitMax = 20.0;

        static Random random = new Random();

        public Waschmaschine(double kochZeit, double schleuderZeit, double kochLeistung, double schleuderLeistung)
        {
            this.kochZeit = kochZeit;
            this.schleuderZeit = schleuderZeit;
            this.kochLeistung = kochLeistung;
            this.schleuderLeistung = schleuderLeistung;
        }

        public double Starte(double zeit)
        {
            double waschZeit = 14 + 6 * random.NextDouble();

            if (zeit >= waschZeitMin && zeit <= waschZeitMax)
            {
                return 90.0;
            }
            else      
                return 0.0;
        }
    }
}
