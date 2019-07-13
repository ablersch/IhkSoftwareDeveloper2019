using System;

namespace Medienauswahl_Aufgabe_2
{
    class Medien
    {
        protected Leihstatus leihstatus;
        protected int signatur = 0;
        protected string titel;
        protected TypBezeichnung typ;

        protected enum Leihstatus 
        {
            präsent,
            entliehen
        };

        protected enum TypBezeichnung
        {
            Video,
            Buch
        };

        public Medien()
        {
            bool signaturValid = false;
            Console.WriteLine("Signatur eingeben: ");
            
            while (!signaturValid)
            {
                signaturValid = int.TryParse(Console.ReadLine(), out signatur);

                if (!signaturValid)
                {
                    Console.WriteLine("Signatur keine Zahl. Erneut eingeben: ");
                    continue;
                }

                if (signatur < 1000)
                {
                    Console.WriteLine("Signatur muss mindestens 4 Zeichen beinhalten. Erneut eingeben:");
                    signaturValid = false;
                }
                else
                {
                    signaturValid = true;
                }
            }

            Console.WriteLine("Titel eingeben:");
            titel = Console.ReadLine();

            leihstatus = Leihstatus.präsent;
        }

        internal void Entleihen(int sig) {
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

        internal void Rueckgabe(int sig) {
            if (signatur == sig)
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
}
