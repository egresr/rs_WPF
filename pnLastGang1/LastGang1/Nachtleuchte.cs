using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastGang1
{
    class Nachtleuchte
    {
        double leistung;
        double leuchtZeiten;




        public Nachtleuchte(double leistung)
        {
            this.leistung = leistung;
        }

        public double Starte(double startZeit)
        {
            if (startZeit >= 14.00 && startZeit <= 20.00)
                return this.leistung;
            else
                return 300.0;
        }
    }
}
