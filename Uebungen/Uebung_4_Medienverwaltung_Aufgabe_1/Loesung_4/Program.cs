using System;

namespace Medienauswahl_Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string auswahl = ""; 
            Medien medien = null;

            Console.WriteLine("Medienverwaltung");

            while (auswahl != "q")
            {
                Console.WriteLine("\n#### Menue ####");
                Console.WriteLine("Anlegen eines neuen Mediums 'm'");
                Console.WriteLine("Ausgabe der vorhandenen Medien 'l'");
                Console.WriteLine("Entleihen des zuletzt angelegten Medium 'e'");
                Console.WriteLine("Rueckgabe des zuletzt angelegten Medium 'r'");
                Console.WriteLine("Programm beenden 'q'\n");

                auswahl = Console.ReadLine();
                
                Console.WriteLine();

                switch (auswahl)
                {
                    case "m": 
                        medien = new Medien();
                        medien.Anlegen();
                        break;

                    case "l":
                        if (medien != null) {
                            medien.List();
                        }
                        break;

                    case "e":
                        if (medien != null) {
                            medien.Entleihen();
                        }
                        break;

                    case "r":
                        if (medien != null) {
                            medien.Rueckgabe();
                        }
                        break;

                    case "q":
                        // "durchrutschen"
                        break;

                    default:
                        Console.WriteLine("\nFalsche Eingabe\n");
                        break;
                }
            }
        }
    }
}
