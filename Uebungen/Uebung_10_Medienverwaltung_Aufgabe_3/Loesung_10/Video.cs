using System;

namespace Medienverwaltung_Aufgabe_3
{
    class Video : Medium
    {
        private double laufzeit;

        public Video()
        {
            typ = TypBezeichnung.Video;
            
            Console.WriteLine("Laufzeit eingeben:");
            laufzeit = Convert.ToDouble(Console.ReadLine());
        }

        internal void Ausgabe()
        {
            // Festkomma Wert mit zwei Kommastellen
            Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} Dauer {4:F2} min", signatur, typ, titel, leihstatus, laufzeit);
        }
    }
}
