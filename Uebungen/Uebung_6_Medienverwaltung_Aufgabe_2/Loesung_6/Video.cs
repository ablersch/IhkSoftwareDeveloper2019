using System;

namespace Medienverwaltung_Aufgabe_2
{
    class Video
    {
        private Leihstatus leihstatus;
        private int signatur;
        private string titel;
        private TypBezeichnung typ;
        private double laufzeit;

        private enum Leihstatus
        {
            präsent,
            entliehen
        };

        private enum TypBezeichnung
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

            Console.WriteLine("Laufzeit eingeben:");
            laufzeit = Convert.ToDouble(Console.ReadLine());

            leihstatus = Leihstatus.präsent;
            typ = TypBezeichnung.Video;
            Console.WriteLine("Buch erfolgreich angelegt!");
        }

        public void Ausgabe()
        {
            // Rechts des Wertes 15 Stellen
            Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} {4,-12}", "Signatur", "Typ", "Titel", "Leihstatus", "Laufzeit");
            Console.WriteLine("{0,-12} {1,-12} {2,-12} {3,-12} Dauer {4:F2} min", signatur, typ, titel, leihstatus, laufzeit);
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
                    Console.WriteLine($"Rueckgabe von {titel} nicht möglich da das Video nicht entliehen ist.");
                }
            }
        }
    }
}
