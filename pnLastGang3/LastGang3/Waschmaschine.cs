namespace LastGang3
{
    internal class Waschmaschine : Verbraucher
    {
        private double aktionsZeit;
        private double endZeit;
        private double leistungWatt;
        private double leistungWattKochen;
        private double leistungWattSchleudern;
        private double startZeit;

        public Waschmaschine(double aktionsZeit, double leistungWatt, double leistungWattKochen, double leistungWattSchleudern, double startZeit, double endZeit)
        {
            this.aktionsZeit = aktionsZeit;
            this.leistungWatt = leistungWatt;
            this.leistungWattKochen = leistungWattKochen;
            this.leistungWattSchleudern = leistungWattSchleudern;
            this.startZeit = startZeit;
            this.endZeit = endZeit;
        }

        //public double Starte()
        //{


        //    return;
        //}



    }
}