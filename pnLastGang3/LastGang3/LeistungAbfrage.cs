using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastGang3
{
    class LeistungAbfrage
    {
        DateTime dateTime;
        static double gesamtLeistung = 0.0;

        public void Berechne(Nachtleuchter nachtLeuchter)
        {
            foreach (DateTime onZeit in nachtLeuchter.ListZeitON)
            {
                int stunde = Convert.ToInt32(onZeit.ToString("HH"));
                int minute = Convert.ToInt32(onZeit.ToString("mm"));
                int sekunde = Convert.ToInt32(onZeit.ToString("ss"));

                ZeitAchseFuellen(stunde, minute, sekunde);
            }
        }

        private void ZeitAchseFuellen(int hh, int mm, int ss)
        {
            for (int stunde = 0; stunde < 24; stunde++)
            {
                for (int minute = 0; minute < 59; minute++)
                {
                    for (int sekunde = 0; sekunde < 59; sekunde++)
                    {
                        if (hh == stunde && mm == minute && ss == sekunde)
                        {
                            double pointPosition = stunde + minute / 60.0 + sekunde / 60.0;
                        }

                    }

                }
            }
        }
    }
}
