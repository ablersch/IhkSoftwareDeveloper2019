using System;

namespace Uebung_Versandhandel
{
    class Buch : Artikel
    {
        public string Buchtitel { get; set; }

        public string Author { get; set; }

        public float Seiten { get; set; } = 0;

        /// <summary>
        /// Ausgabe überschreiben durch erweiterte Ausgabe für das Buch
        /// </summary>
        public override void Ausgabe()
        {
            Console.WriteLine($"Der Titel lautet: {Buchtitel}");
            Console.WriteLine($"Der Author ist: {Author}");
            Console.WriteLine($"Das Buch hat: {Seiten} Seiten");
            Console.WriteLine($"\nDie Bezeichnung lautet: {Bezeichnung}");
            Console.WriteLine($"Die Anzahl ist: {Anzahl}");
            Console.WriteLine($"Die Nummer ist: {Nummer}");
            Console.WriteLine($"Der Preis ist: {Preis}");
        }
    }
}
