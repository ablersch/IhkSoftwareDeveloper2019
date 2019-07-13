using System;

namespace Uebung_Versandhandel
{
    class Program
    {
        static void Main(string[] args)
        {
            Buch neuesBuch = new Buch();
            neuesBuch.Buchtitel = "Der Herr der Ringe";
            neuesBuch.Seiten = 1344;
            neuesBuch.Author = "J. R. R. Tolkien";

            neuesBuch.Bezeichnung = $"BUCH - {neuesBuch.Buchtitel}";
            neuesBuch.Preis = 88.00;
            neuesBuch.Anzahl = 4;
            neuesBuch.Nummer = 542684169;

            neuesBuch.Ausgabe();
            Console.ReadLine();
        }
    }
}
