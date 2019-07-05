
using System;

namespace Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            new Fahrzeug(12);
            new Fahrzeug(1800, 29332312);
        }
    }

    class Fahrzeug
    {
        private int gewicht;
        private int fahrzeugId;

        public Fahrzeug() :this(0, 0)
        {
        }

        public Fahrzeug(int gew) :this (gew, 0)
        {
        }

        public Fahrzeug(int gew, int id)
        {
            gewicht = gew;
            fahrzeugId = id;
        }
    }
}
