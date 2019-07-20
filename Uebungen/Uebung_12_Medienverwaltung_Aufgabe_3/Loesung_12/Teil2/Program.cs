using System;

namespace Medienauswahl_Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string auswahl = "";
            int signatur = 0;
            Medien tempMedien = null;

            Console.WriteLine("Medienverwaltung");

            while (auswahl != "q")
            {
                Console.WriteLine("\n#### Menue ####");
                Console.WriteLine("Anlegen eines neuen Buch 'b'");
                Console.WriteLine("Anlegen eines neuen Video 'v'");
                Console.WriteLine("Ausgabe der vorhandenen Medien 'l'");
                Console.WriteLine("Entleihen eines Medium 'e Signatur'");
                Console.WriteLine("Rueckgabe eines Medium 'r Signatur'");
                Console.WriteLine("Löschen eines Medium 'd Signatur'");
                Console.WriteLine("Programm beenden 'q'\n");

                auswahl = Console.ReadLine();
                if (auswahl != null && auswahl.Length > 5)
                {
                    string[] temp = auswahl.Split(' ');
                    auswahl = temp[0];
                    signatur = Convert.ToInt32(temp[1]);
                }

                Console.WriteLine();
                switch (auswahl)
                {
                    case "b":
                        new Buecher();
                        break;
                    
                    case "v":
                        new Videos();
                        break;

                    case "l":
                        // Für die Spaltenüberschrift
                        Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} {4,-12}", "Signatur", "Typ", "Titel", "Leihstatus", "Eigenschaften");

                        foreach (Medien medienObj in Data.GetAllElements())
                        {
                            if (medienObj is Buecher)
                            {
                                Buecher buch = medienObj as Buecher;
                                buch.List();
                            }
                            else if (medienObj is Videos)
                            {
                                ((Videos)medienObj).List();
                            }
                        }
                        break;

                    case "e":
                        tempMedien = Data.GetElement(signatur);
                        if (tempMedien != null)
                        {
                            tempMedien.Entleihen();
                        }
                        break;

                    case "r":
                        tempMedien = Data.GetElement(signatur);
                        if (tempMedien != null)
                        {
                            tempMedien.Rueckgabe();
                        }

                        break;

                    case "d":
                        Data.DeleteElement(signatur);
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
