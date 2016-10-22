using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class MyMeeting
    {
        //Felder, Instanzvariablen, Attribute
        DateTime when; //wann
        TimeSpan duration; //dauer
        string title;

        //Methode
        public bool IstAktuell() // ist Aktuell (jetzt)
                            //wenn "public" -> IsNow.
                            //wenn "privat" -> isNow.
        {
            DateTime now = DateTime.Now;
            return now >= when && now <= when + duration;
        }

        public void Verschieben (double stunden)
        {
            when += TimeSpan.FromHours(stunden);
        }
    }
}
