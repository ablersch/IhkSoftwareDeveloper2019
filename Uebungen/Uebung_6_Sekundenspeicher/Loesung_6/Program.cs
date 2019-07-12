using System;

namespace Uebung_Sekundenspeicher
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong secondsValue;
            Seconds seconds = null;

            Console.WriteLine("Sekunden eingeben:");
            var input = Console.ReadLine();

            if (ulong.TryParse(input, out secondsValue))
            {
                seconds = new Seconds(secondsValue);
            }
            else
            {
                // Keine Zahl eingegeben. Das Programm wird beendet
                Environment.Exit(0);
            }

            Console.WriteLine($"\nSekunden: {seconds.GetSeconds()}");
            Console.WriteLine($"Minuten: {seconds.GetMinutes()}");
            Console.WriteLine($"Stunden: {seconds.GetHours()}");
            Console.WriteLine($"Tage: {seconds.GetDays()}");


            // Erweiterte Sekundenaufgabe

            SecondsExtended secondsExtended = new SecondsExtended();
            secondsExtended.Seconds = secondsValue;

            // alternativ Methoden aufrufen und Werte in Variable speichern
            ulong tage = secondsExtended.GetDays();
            ulong stunden = secondsExtended.GetHours();
            ulong minuten = secondsExtended.GetMinutes();
            ulong sek = secondsExtended.GetSeconds();

            Console.WriteLine("\nErweitert:");
            Console.WriteLine($"Tage: {tage} Stunden: {stunden} Minuten: {minuten} Sekunden: {sek}");
            
            Console.WriteLine("\nTaste drücken um zu beenden...");
            Console.ReadKey();
        }
    }
}
