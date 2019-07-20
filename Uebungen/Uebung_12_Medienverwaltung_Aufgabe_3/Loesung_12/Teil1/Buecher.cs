using System;

namespace Medienauswahl_Aufgabe_3_Teil_1
{
    class Buecher : Medien
    {
        private int seitenzahl;

        public Buecher()
        {
            typ = TypBezeichnung.Buch;
            
            Console.WriteLine("Seitenzahl eingeben:");
            while (!int.TryParse(Console.ReadLine(), out seitenzahl) )
            {
                Console.WriteLine("Seitenzahl nicht gültig. Bitte nur ganze Zahlen eingeben:");
            }
        }

        internal void List()
        {
            Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} Seitenzahl {4,-12}", signatur, typ, (titel.Length > 12) ? titel.Substring(0, 12) : titel, leihstatus, seitenzahl);
        }
    }
}
