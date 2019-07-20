using System;

namespace Medienauswahl_Aufgabe_3
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
            signatur = GenerateSignatur();

            Console.WriteLine("Titel eingeben:");
            titel = Console.ReadLine();

            leihstatus = Leihstatus.präsent;

            Data.AddData(signatur, this);
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

        private int GenerateSignatur()
        {
            Random random = new Random();
            int newKey = 0;

            do
            {
                newKey = random.Next(1000, 100000);
            } while (!Data.IsKeyEindeutig(newKey));

            return newKey;
        }
    }
}
