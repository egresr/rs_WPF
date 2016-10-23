using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    //1
    class MyMeeting
    {
        //Felder, Instanzvariablen, Attribute
        DateTime when; //wann
        TimeSpan duration; //dauer
        string title;

        //5 Direkte Initialisierung
        //DateTime when = DateTime.Now; //wann
        //TimeSpan duration = TimeSpan.FromHours(2.0); //dauer
        //string title = "Unbenannt";

        //6 Konstriktor, Konstruktor ueberladen
        public MyMeeting() // Parameterlose Konstruktor, Standardkonstruktor, default constructor
        {
            when = DateTime.Now;
            duration = TimeSpan.FromHours(2.0);
            title = "Unbenannt";
        }

        //7 Konstruktor mit Parameter
        public MyMeeting(double hours)
        {
            when = DateTime.Now;
            duration = TimeSpan.FromHours(hours);
            title = "Unbenannt";
        }

        //9 Konstruktor mit Parameter
        //public MyMeeting(DateTime a, TimeSpan b, string c)
        //{
        //    when = a;
        //    duration = b;
        //    title = c;
        //}

        //10 Konstruktor mit Parameter
        public MyMeeting(DateTime when, TimeSpan duration, string title)
        {
            this.when = when;               //this- Verweis auf aktuelle Instanz
            this.duration = duration;       //this.variable- Verweis auf variable von aktuelle Instanz
            this.title = title;
        }

        //2
        //Methode
        public bool IstAktuell() // ist Aktuell (jetzt)
                                 //wenn "public" -> IsNow.
                                 //wenn "privat" -> isNow.
        {
            DateTime now = DateTime.Now;
            //3
            return now >= when && now <= when + duration;
        }

        //4 Methoden ueberladen, Overloading
        public void Verschieben(double stunden)
        {
            when += TimeSpan.FromHours(stunden);
        }

        public void Verschieben(TimeSpan ts)
        {
            when += ts;
        }

        //11 Getter und Setter
        //public TimeSpan get_Druation()
        //{
        //    return duration;
        //}

        //public void set_Duration(TimeSpan duration)
        //{
        //    this.duration = duration;
        //}

        //13
        // Properties
        public TimeSpan Duration
        {
            get{ return duration; }
            set{ duration = value; }
        }
    }
}
