using System;

namespace Medienauswahl_Aufgabe_1
{
    class Medien
    {
        private Leihstatus leihstatus;
        private int signatur;
        private string titel;

        private enum Leihstatus
        {
            präsent,
            entliehen
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

            leihstatus = Leihstatus.präsent;
            Console.WriteLine("Medium erfolgreich angelegt!");
        }

        internal void List()
        {
            Console.WriteLine("Medienbestand");
            // Rechts des Wertes 15 Stellen
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Signatur", "Titel", "Leihstatus");
            Console.WriteLine("{0,-15} {1,-15} {2,-15}", signatur, titel, leihstatus);
        }

        internal void Entleihen()
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

        internal void Rueckgabe()
        {
            if (leihstatus == Leihstatus.entliehen)
            {
                leihstatus = Leihstatus.präsent;
                Console.WriteLine($"{titel} erfolgreich zurueckgegeben.");
            }
            else
            {
                Console.WriteLine($"Rueckgabe von {titel} nicht möglich da das Medium nicht entliehen ist.");
            }
        }
    }
}
