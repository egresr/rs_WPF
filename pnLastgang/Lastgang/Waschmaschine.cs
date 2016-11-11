using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lastgang
{
    class Waschmaschine
    {
        double kochenWattZahl;
        double schleudernWattZahl;
        double startZeitRandom;

        static Random random = new Random();



        public Waschmaschine(double kochenWattZahl, double schleudernWattZahl)
        {
            this.kochenWattZahl = kochenWattZahl;
            this.schleudernWattZahl = schleudernWattZahl;

            //startZeitRandom = 14 + 6 * random.NextDouble();
            startZeitRandom = 0 + 1 * random.NextDouble();
        }

        public double StarteWaschmaschine(double startZeit, double kochenDauer, double schleudernDauer)
        {

            if (startZeit >= startZeitRandom && startZeit <= startZeitRandom + kochenDauer)
            {
                return kochenWattZahl;
            }

            else if (startZeit >= startZeitRandom + kochenDauer && startZeit <= startZeitRandom + schleudernDauer)
            {
                return schleudernWattZahl;
            }
            else
            {
                return 0.0;
            }

        }
    }
}
