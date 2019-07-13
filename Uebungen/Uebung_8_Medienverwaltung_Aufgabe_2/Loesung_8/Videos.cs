using System;

namespace Medienauswahl_Aufgabe_2
{
    class Videos : Medien
    {
        private double laufzeit;

        public Videos()
        {
            typ = TypBezeichnung.Video;
            
            Console.WriteLine("Laufzeit eingeben:");
            laufzeit = Convert.ToDouble(Console.ReadLine());
        }

        internal void List()
        {
            // Festkomma Wert mit zwei Kommastellen
            Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} Dauer {4:F2} min", signatur, typ, titel, leihstatus, laufzeit);
        }
    }
}
