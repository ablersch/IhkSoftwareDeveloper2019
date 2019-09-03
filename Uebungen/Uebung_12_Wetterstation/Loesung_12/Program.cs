using System;
using System.Collections;
using System.Collections.Generic;

namespace Uebung_Wetterstation {

    class Program {
        static void Main(string[] args) 
        {         
            var station = new List<Wetter>();

            station.Add(new Wetter("Station Scott", -55, -2, 800, 0)); // Objekt instanziieren
            station.Add(new Wetter("Station Tunis", 115, 30, 1030, 0));
            station.Add(new Wetter("Station Wien", 15, 70, 930, 3));

            Console.WriteLine("Messbereiche der Wetterstationen");
            Console.WriteLine("Temperatur: - 80 bis + 100 Grad Celsius Luftfeuchtigkeit: 0 bis 100 Prozent");
            Console.WriteLine("Druck: 700 hPa bis 1500 hPa Niederschlag: 0 bis 100 Liter");

            Console.WriteLine();

            foreach (var wetter in station)
            {
                Console.WriteLine($"{wetter.StationsName} Temperatur: {wetter.Temperatur} Feuchtigkeit: {wetter.Luftfeuchtigkeit} " +
                    $"Luftdruck: {wetter.Luftdruck} Regenmenge: {wetter.Regenmenge}");
            }
            Console.Write("\nBitte die Eingabetaste drücken");
            Console.ReadLine();
        }
    }
}
