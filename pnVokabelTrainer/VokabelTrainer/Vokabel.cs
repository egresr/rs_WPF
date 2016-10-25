using System;
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
        DateTime letzteAbfrage;
        int zahlKorrekterAbfragen;
        int zahlFehlgeschlagenerAbfragen;

        Vokabel(string deutchesWort, string englischeUebersetzung, int zahlKorrekterAbfragen, int zahlFehlgeschlagenerAbfragen)
        {
            this.deutchesWort = deutchesWort;
            this.englischeUebersetzung = englischeUebersetzung; 
        }

    }
}
