﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabelTrainer
{
    class Vokabel
    {
        string deutchesWort;
        string englischeUebersetzung;
        DateTime erstellungsDatum;
        DateTime letzteAbfrage;   //TODO
        int zahlKorrekterAbfragen;  //TODO
        int zahlFehlgeschlagenerAbfragen; //TODO

        public string DeutschesWort
        {
            get { return deutchesWort; }
            set { }
        } 

        public int ZahlKorrekteAbfragen
        {
            get { return zahlKorrekterAbfragen; }
        }

        public int ZahlFehlgeschlageneAbfragen
        {
            get { return zahlFehlgeschlagenerAbfragen; }
        }

        public DateTime LetzteAbfrage
        {
            get { return letzteAbfrage; }
        }

        public DateTime ErstellungsDatum
        {
            get { return erstellungsDatum; }
        }

        public Vokabel(string deutchesWort, string englischeUebersetzung)
        {
            this.deutchesWort = deutchesWort;
            this.englischeUebersetzung = englischeUebersetzung;
            erstellungsDatum = DateTime.Now;
        }

        public bool Pruefe(string text)
        {
            letzteAbfrage = DateTime.Now;

            if (englischeUebersetzung == text)
            {
                zahlKorrekterAbfragen ++;
                return true;
            }
            else
            {
                zahlFehlgeschlagenerAbfragen ++;
                return false;
            }  
        }
    }
}
