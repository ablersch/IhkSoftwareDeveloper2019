using System;

namespace Uebung_Banksystem
{
    public class Kunde
    {
        private string name;

        private int alter;

        public string Name { get => name; set => name = value; }
        public int Alter { get => alter; set => alter = value; }

        // TODO bearbeiten vom Kunde
        // TODO mehrere Kunden

        public Kunde()
        {
            Console.WriteLine("Inhaber Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Alter:");
            while (!int.TryParse(Console.ReadLine(), out alter))
            {
                Console.WriteLine("Kein gültiges Alter eingegeben");
            }
        }

        public void AusgabeInhaber()
        {
            Console.WriteLine("Inhaber");
            Console.WriteLine($"Name: { Name}");
            Console.WriteLine($"Alter: { Alter}");
        }
    }
}
