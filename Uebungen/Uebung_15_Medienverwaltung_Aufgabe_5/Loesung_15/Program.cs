using System;
using System.Collections.Generic;
using Logger;

namespace Medienverwaltung_Aufgabe_5
{
    class Program
    {
        public static Dictionary<int, Medium> medienDic = new Dictionary<int, Medium>();

        static void Main(string[] args)
        {
            Medium tempMedium = null;
            string auswahl = "a";
            int signatur = 0;

            Console.WriteLine("Medienverwaltung");

            while (auswahl != "q")
            {
                Console.WriteLine("\n#### Menue ####");
                Console.WriteLine("Anlegen eines neuen Buch 'b'");
                Console.WriteLine("Anlegen eines neuen Video 'v'");
                Console.WriteLine("Ausgabe der vorhandenen Medien 'a'");
                Console.WriteLine("Entleihen des Medium 'e Signatur'");
                Console.WriteLine("Rueckgabe des Medium 'r Signatur'");
                Console.WriteLine("Löschen des Medium 'l Signatur'");
                Console.WriteLine("Programm beenden 'q'\n");

                auswahl = Console.ReadLine();
                signatur = 0;
                if (auswahl.Length > 5)
                {
                    string[] temp = auswahl.Split(' ');
                    auswahl = temp[0];
                    if (!int.TryParse(temp[1], out signatur))
                    {
                        Console.WriteLine("Keine gültige Signatur eingegeben");
                        continue;
                    }
                }

                Console.WriteLine();
                switch (auswahl)
                {
                    case "b":
                        tempMedium = new Buch();
                        medienDic.Add(tempMedium.signatur, tempMedium);
                        break;

                    case "v":
                        tempMedium = new Video();
                        medienDic.Add(tempMedium.signatur, tempMedium);
                        break;

                    case "a":
                        Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} {4,-12}", "Signatur", "Typ", "Titel", "Leihstatus", "Eigenschaften");
                        foreach (var medium in medienDic)
                        {
                            if (medium.Value is Buch)
                            {
                                (medium.Value as Buch).Ausgabe();
                            }
                            else if (medium.Value is Video)
                            {
                                (medium.Value as Video).Ausgabe();
                            }
                        }
                        break;

                    case "e":
                        tempMedium = GetElement(signatur);
                        try
                        {
                            tempMedium?.Entleihen(signatur);
                        }
                        catch (StatusErrorException statusErrorException)
                        {
                            Console.WriteLine(statusErrorException.Message);
                        }
                        break;

                    case "r":
                        tempMedium = GetElement(signatur);
                        try
                        {
                            tempMedium?.Rueckgabe(signatur);
                        }
                        catch (StatusErrorException statusErrorException)
                        {
                            Console.WriteLine(statusErrorException.Message);
                        }
                        break;

                    case "l":
                        if (medienDic.ContainsKey(signatur))
                        {
                            medienDic.Remove(signatur);
                            Console.WriteLine($"Medium mit der Signatur: {signatur} erfolgreich gelöscht.");
                        }
                        else
                        {
                            Console.WriteLine("Signatur nicht gefunden!");
                        }
                        break;

                    case "q":
                        // "durchrutschen"
                        break;
                    default:
                        Console.WriteLine("Falsche Eingabe\n");
                        break;
                }
            }
        }

        /// <summary>
        /// Gibt ein Medium Objekt aus dem Dictionary
        /// </summary>
        /// <param name="key">Signatur</param>
        /// <returns>Medien Objekt; Bei Fehler null</returns>
        static Medium GetElement(int key)
        {
            if (medienDic.ContainsKey(key))
            {
                return medienDic[key];
            }
            else
            {
                Console.WriteLine($"Signatur: {key} nicht gefunden!");
                return null;
            }
        }
    }
}
