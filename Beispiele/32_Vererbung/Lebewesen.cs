using System;

namespace Vererbung
{
    class Lebewesen
    {
        // nur in den vererbenden Klassen verfügbar nicht von außerhalb
        private int alter;

        public Lebewesen(): this(5)  // Zugriff auf Konstruktor der selben Klasse
        {
            alter = 50;
            Console.WriteLine($"Default Konstruktor Lebewesen Alter: {alter}");
        }

        public Lebewesen(int alterInput)
        {
            alter = alterInput;
            Console.WriteLine($"Konstruktor Lebewesen Alter: {alter}");
        }

        public int GetAlter()
        {
            Console.WriteLine("GetAlter Lebewesen");
            return alter;
        }
    }
}
