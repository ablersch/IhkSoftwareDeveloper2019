using System;
using System.Collections.Generic;

namespace Medienauswahl_Aufgabe_3_Teil_1
{
    class Program
    {
        public static Dictionary<int, Medien> medienDic = new Dictionary<int, Medien>();

        static void Main(string[] args)
        {
            Medien tempMedien = null;
            string auswahl = "a";
            int signatur = 0;

            Console.WriteLine("Medienverwaltung");

            while (auswahl != "q")
            {
                Console.WriteLine("\n#### Menue ####");
                Console.WriteLine("Anlegen eines neuen Buch 'b'");
                Console.WriteLine("Anlegen eines neuen Video 'v'");
                Console.WriteLine("Ausgabe der vorhandenen Medien 'l'");
                Console.WriteLine("Entleihen des zuletzt angelegten Medium 'e Signatur'");
                Console.WriteLine("Rueckgabe des zuletzt angelegten Medium 'r Signatur'");
                Console.WriteLine("Löschen eines Medium 'd Signatur'");
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
                        tempMedien = new Buecher();
                        medienDic.Add(tempMedien.signatur, tempMedien);
                        break;

                    case "v":
                        tempMedien = new Videos();
                        medienDic.Add(tempMedien.signatur, tempMedien);
                        break;

                    case "l":
                        Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} {4,-12}", "Signatur", "Typ", "Titel", "Leihstatus", "Eigenschaften");
                        foreach (var medium in medienDic)
                        {
                            if (medium.Value is Buecher)
                            {
                                (medium.Value as Buecher).List();
                            }
                            else if (medium.Value is Videos)
                            {
                                (medium.Value as Videos).List();
                            }
                        }
                        break;

                    case "e":
                        tempMedien = GetElement(signatur);
                        if (tempMedien != null)
                        {
                            if (tempMedien is Buecher)
                            {
                                (tempMedien as Buecher).Entleihen(signatur);
                            }
                            else if (tempMedien is Videos)
                            {
                                (tempMedien as Videos).Entleihen(signatur);
                            }
                        }
                        break;

                    case "r":
                        tempMedien = GetElement(signatur);
                        if (tempMedien != null)
                        {
                            if (tempMedien is Buecher)
                            {
                                (tempMedien as Buecher).Rueckgabe(signatur);
                            }
                            else if (tempMedien is Videos)
                            {
                                (tempMedien as Videos).Rueckgabe(signatur);
                            }
                        }
                        break;

                    case "d":
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
        /// Gibt ein Medien Objekt aus dem Dictionary
        /// </summary>
        /// <param name="key">Signatur</param>
        /// <returns>Medien Objekt; Bei Fehler null</returns>
        static Medien GetElement(int key)
        {
            if (key == 0)
            {
                Console.WriteLine("Keine gültige Signatur eingegeben");
                return null;
            }

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
