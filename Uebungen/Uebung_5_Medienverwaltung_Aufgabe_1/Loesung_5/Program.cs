using System;

namespace Medienverwaltung_Aufgabe_1
{
    class Program
    {
        private static Leihstatus leihstatus;
        private static int signatur;
        private static string titel;

        private enum Leihstatus
        {
            präsent,
            entliehen
        };

        static void Main(string[] args)
        {
            string auswahl = "";

            Console.WriteLine("Medienverwaltung");

            // Menü, wird immer wiederholt angezeigt bis es mit 'q' beendet wird.
            while (auswahl != "q")
            {
                Console.WriteLine("\n#### Menue ####");
                Console.WriteLine("Anlegen eines neuen Buch 'b'");
                Console.WriteLine("Ausgabe des vorhandenen Buch 'a'");
                Console.WriteLine("Entleihen des angelegten Buch 'e'");
                Console.WriteLine("Rueckgabe des Buch 'r'");
                Console.WriteLine("Programm beenden 'q'\n");

                auswahl = Console.ReadLine();

                Console.WriteLine();

                switch (auswahl)
                {
                    case "b":
                        Anlegen();
                        break;

                    case "a":
                        Ausgabe();
                        break;

                    case "e":
                        Entleihen();
                        break;

                    case "r":
                        Rueckgabe();
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

        /// <summary>
        /// Legt ein neues Buch an
        /// </summary>
        public static void Anlegen()
        {
            Console.WriteLine("Signatur eingeben: ");

            while (!int.TryParse(Console.ReadLine(), out signatur))
            {
                Console.WriteLine("Signatur ist keine Zahl. Erneut eingeben: ");
            }

            Console.WriteLine("Titel eingeben:");
            titel = Console.ReadLine();

            leihstatus = Leihstatus.präsent;
            Console.WriteLine("Buch erfolgreich angelegt!");
        }

        /// <summary>
        /// Ausgabe der Buchdaten
        /// </summary>
        public static void Ausgabe()
        {
            Console.WriteLine("Ausgabe");
            // Rechts des Wertes 15 Stellen
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Signatur", "Titel", "Leihstatus");
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", signatur, titel, leihstatus);
        }

        /// <summary>
        /// Entleiht ein Buch wenn es nicht entliehen ist
        /// </summary>
        public static void Entleihen()
        {
            if (leihstatus == Leihstatus.präsent)
            {
                leihstatus = Leihstatus.entliehen;
                Console.WriteLine($"{titel} erfolgreich ausgeliehen.");
            }
            else
            {
                Console.WriteLine($"{titel} ist bereits entliehen.");
            }
        }

        /// <summary>
        /// Gibt ein Buch zurück wenn es entliehen ist
        /// </summary>
        public static void Rueckgabe()
        {
            if (leihstatus == Leihstatus.entliehen)
            {
                leihstatus = Leihstatus.präsent;
                Console.WriteLine($"{titel} erfolgreich zurueckgegeben.");
            }
            else
            {
                Console.WriteLine($"Rueckgabe von {titel} nicht möglich da das Buch nicht entliehen ist.");
            }
        }
    }
}
