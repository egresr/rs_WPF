using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lastgang
{
    class Nachtleuchte
    {
        double wattzahl;
        public Nachtleuchte(double wattzahl)
        {
            this.wattzahl = wattzahl;
        }

        public double BestimmeLeistung(double zeit) // zeit in Stunden
        {
            if(zeit < 6 || zeit > 20)
            {
                return this.wattzahl;
            }
            return 0.0;
        }
    }
}
