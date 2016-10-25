using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wecker
{
    class Termin
    {
        string title;
        byte stunden;
        byte minuten;

        //public string Title { get; set; }
        //public byte Stunden { get; set; }
        //public byte Minuten { get; set; }

        public Termin(string title, byte stunden, byte minuten)
        {
            this.title = title;
            this.stunden = stunden;
            this.minuten = minuten;
        }

        public override string ToString() // Ueberschreiben von ToString()- Methode
        {

            return stunden.ToString("D2") + ":" + minuten.ToString("D2") + "\t" + title; // Ueberschreiben von ToSting
        }                                                                                // und formatierte string Convertierung
    }
}
