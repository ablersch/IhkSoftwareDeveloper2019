using System;

namespace Uebung_Versandhandel
{
    abstract class Artikel
    {
        // Muss von der Kindklasse implementiert werden.
        public abstract void Ausgabe();

        public int Anzahl { get; set; }

        public double Preis { get; set; }

        public string Bezeichnung { get; set; }

        public int Nummer { get; set; }
    }
}
