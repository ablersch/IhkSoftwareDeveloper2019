using System;

namespace Medienverwaltung_Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string auswahl = "x";
            int signatur;
            Buch buchObj = null;
            Video videoObj = null;

            Console.WriteLine("Medienverwaltung");

            while (auswahl != "q")
            {
                Console.WriteLine("\n#### Menue ####");
                Console.WriteLine("Anlegen eines neuen Buch 'b'");
                Console.WriteLine("Anlegen eines neuen Video 'v'");
                Console.WriteLine("Ausgabe der vorhandenen Medien 'a'");
                Console.WriteLine("Entleihen des Medium 'e Signatur'");
                Console.WriteLine("Rueckgabe des Medium 'r Signatur'");
                Console.WriteLine("Programm beenden 'q'\n");

                auswahl = Console.ReadLine();

                // Die Eingabe ' e 12345' aufteilen um die Auswahl, also 'e' zu erhalten und eventuell eine gefolgte Signatur.
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
                        buchObj = new Buch();
                        buchObj.Anlegen();
                        break;

                    case "v":
                        videoObj = new Video();
                        videoObj.Anlegen();
                        break;

                    case "a":
                        Console.WriteLine("Ausgabe");
                        if (buchObj != null)
                        {
                            buchObj.Ausgabe();
                        }
                        if (videoObj != null)
                        {
                            videoObj.Ausgabe();
                        }
                        break;

                    case "e":
                        if (buchObj != null)
                        {
                            buchObj.Entleihen(signatur);
                        }

                        // Null-conditional operator
                        videoObj?.Entleihen(signatur);

                        break;

                    case "r":
                        buchObj?.Rueckgabe(signatur);
                        videoObj?.Rueckgabe(signatur);
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
