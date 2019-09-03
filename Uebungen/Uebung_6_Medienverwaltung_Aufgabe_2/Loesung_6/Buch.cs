using System;

namespace Medienverwaltung_Aufgabe_2
{
    class Buch
    {
        private Leihstatus leihstatus;
        private int signatur;
        private string titel;
        private TypBezeichnung typ;
        private int seitenzahl;

        private enum Leihstatus
        {
            präsent,
            entliehen
        };

        protected enum TypBezeichnung
        {
            Video,
            Buch
        };

        public void Anlegen()
        {
            Console.WriteLine("Signatur eingeben: ");

            while (!int.TryParse(Console.ReadLine(), out signatur))
            {
                Console.WriteLine("Signatur ist keine Zahl. Erneut eingeben: ");
            }

            Console.WriteLine("Titel eingeben:");
            titel = Console.ReadLine();

            Console.WriteLine("Seitenzahl eingeben:");
            while (!Int32.TryParse(Console.ReadLine(), out seitenzahl))
            {
                Console.WriteLine("Seitenzahl nicht gültig. Bitte nur ganze Zahlen eingeben:");
            }

            typ = TypBezeichnung.Buch;
            leihstatus = Leihstatus.präsent;
            Console.WriteLine("Buch erfolgreich angelegt!");
        }

        public void Ausgabe()
        {
            // Rechts des Wertes 15 Stellen
            Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} {4,-12}", "Signatur", "Typ", "Titel", "Leihstatus", "Seitenzahl");
            Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} {4,-12}", signatur, typ, titel, leihstatus, seitenzahl);
        }

        public void Entleihen(int sig)
        {
            if (signatur == sig)
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
        }

        public void Rueckgabe(int sig)
        {
            if (signatur == sig)
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
}
