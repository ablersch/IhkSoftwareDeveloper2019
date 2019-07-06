using System;

namespace Uebung_Intervall
{
    class Program
    {
        static void Main(string[] args)
        {
            Intervall myIntervall = new Intervall(111, 12);
            myIntervall.IntervallAusgabe("Werte:");

            Console.WriteLine($"Intervallgroesse: \n{myIntervall.Size()} ");

            Console.WriteLine($"\nMittelwert: \n{myIntervall.Avg()} \n");
            
            myIntervall.Move(10);
            myIntervall.IntervallAusgabe("Verschiebung: ");

            myIntervall.Scale(10);
            myIntervall.IntervallAusgabe("Skalieren: ");

            Console.ReadLine();
        }
    }
}
