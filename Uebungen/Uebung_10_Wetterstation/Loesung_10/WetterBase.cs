
namespace Uebung_Wetterstation
{

    class WetterBase {
        // Temperatur: - 40 bis + 80 Grad Celsius
        private int temperatur = 0;
        // Luftfeuchtigkeit: 0 bis 100 Prozent
        private int luftfeuchtigkeit = 0;


        public string StationsName { get; set; } = "";

        public int Luftfeuchtigkeit 
        {
            get { return luftfeuchtigkeit; }               

            set                                 
            {
                luftfeuchtigkeit = value;                  
                if (value < 0) luftfeuchtigkeit = 0;       
                if (value > 100) luftfeuchtigkeit = 100;
            }
        }

        // Member Temperatur darf überschrieben werden
        public virtual int Temperatur
        {
            get { return temperatur; }

            set
            {
                temperatur = value;
                if (value < -40) temperatur = -40;
                if (value > 80) temperatur = 80;
            }
        }
    }
}
