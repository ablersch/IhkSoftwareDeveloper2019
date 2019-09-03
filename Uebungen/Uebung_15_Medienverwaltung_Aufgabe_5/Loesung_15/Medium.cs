using System;

namespace Medienverwaltung_Aufgabe_5
{
    class Medium
    {
        public Leihstatus leihstatus;
        public int signatur = 0;
        public string titel;
        public TypBezeichnung typ;

        public enum Leihstatus
        {
            präsent,
            entliehen
        };

        public enum TypBezeichnung
        {
            Video,
            Buch
        };

        public Medium()
        {
            signatur = SignaturErzeugen();

            Console.WriteLine("Titel eingeben:");
            titel = Console.ReadLine();

            leihstatus = Leihstatus.präsent;
        }

        internal void Entleihen(int sig)
        {
            if (signatur == sig)
            {
                if (leihstatus == Leihstatus.präsent)
                {
                    leihstatus = Leihstatus.entliehen;
                    Console.WriteLine(titel + " efolgreich ausgeliehen.");
                }
                else
                {
                    throw new StatusErrorException(signatur.ToString());
                }
            }
        }

        internal void Rueckgabe(int sig)
        {
            if (signatur == sig)
            {
                if (leihstatus == Leihstatus.entliehen)
                {
                    leihstatus = Leihstatus.präsent;
                    Console.WriteLine(titel + " efolgreich zurueckgegeben.");
                }
                else
                {
                    throw new StatusErrorException(signatur.ToString());
                }
            }
        }

        private int SignaturErzeugen()
        {
            Random random = new Random();
            int newKey;
            do
            {
                newKey = random.Next(1000, 100000);
            } while (Program.medienDic.ContainsKey(newKey));

            return newKey;
        }
    }
}
