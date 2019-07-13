using System;

namespace Medienauswahl_Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string auswahl = "a";
            int signatur;
            Videos video = null;
            Buecher buch = null;

            Console.WriteLine("Medienverwaltung");

            while (auswahl != "q")
            {
                Console.WriteLine("\n#### Menue ####");
                Console.WriteLine("Anlegen eines neuen Buch 'b'");
                Console.WriteLine("Anlegen eines neuen Video 'v'");
                Console.WriteLine("Ausgabe der vorhandenen Medien 'l'");
                Console.WriteLine("Entleihen des zuletzt angelegten Medium 'e Signatur'");
                Console.WriteLine("Rueckgabe des zuletzt angelegten Medium 'r Signatur'");
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
                        buch = new Buecher();
                        break;
                    
                    case "v":
                        video = new Videos();
                        break;

                    case "l":
                        Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} {4,-12}", "Signatur", "Typ", "Titel", "Leihstatus", "Eigenschaften");
                        if (video != null) 
                        {
                            video.List();
                        } 
                        if (buch != null)
                        {
                            buch.List();
                        }
                        break;

                    case "e":
                        if (signatur == 0 )
                        {
                            Console.WriteLine("Keine gültige Signatur zum entleihen eingegeben");
                            continue;
                        }
                        if (video != null)
                        {
                            video.Entleihen(signatur);
                        }
                        if (buch != null)
                        {
                            buch.Entleihen(signatur);
                        }
                        break;

                    case "r":
                        if (signatur == 0)
                        {
                            Console.WriteLine("Keine gültige Signatur zum zurückgeben eingegeben");
                            continue;
                        }
                        if (video != null)
                        {
                            video.Rueckgabe(signatur);
                        }
                        if (buch != null)
                        {
                            buch.Rueckgabe(signatur);
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
    }
}
