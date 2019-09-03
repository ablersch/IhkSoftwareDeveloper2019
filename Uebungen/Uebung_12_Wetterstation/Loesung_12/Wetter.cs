
namespace Uebung_Wetterstation
{
    sealed class Wetter : WetterBase{

        // Temperatur: - 80 bis + 100 Grad Celsius (modifiziert aus Basisklasse)
        private int temperatur = 0;          
        // Druck: 700 hPa bis 1500 hPa 
        private int luftdruck = 0;
        // Niederschlag: 0 bis 100 Liter 
        private int niederschlag = 0;


        // Einführen eines neuen Konstruktors mit 5 Parametern
        public Wetter(string station, int temp, int luftfeuchtigkeit, int luftdruck, int regenmenge)
        {
            StationsName = station;
            Temperatur = temp;
            Luftfeuchtigkeit = luftfeuchtigkeit;      // Member der Basisklasse
            Luftdruck = luftdruck;                
            Regenmenge = regenmenge;    
        }

        // Überschreibe Member Temperatur (neue Grenzen -80 bis 100 Grad)
        public override int Temperatur 
        {
            get { return temperatur; }      

            set                      
            {
                temperatur = value;                     
                if (value < -80) temperatur = -80; 
                if (value > 80) temperatur = 80;
            }
        }

        public int Luftdruck    
        {
            get { return luftdruck; }                   

            set                               
            {
                luftdruck = value;           
                if (value < 700) luftdruck = 700;
                if (value > 1500) luftdruck = 1500;
            }
        }

        public int Regenmenge 
        {
            get { return niederschlag; }          

            set                      
            {
                niederschlag = value;            
                if (value < 0) niederschlag = 0; 
                if (value > 100) niederschlag = 100;
            }
        }
    }
}
