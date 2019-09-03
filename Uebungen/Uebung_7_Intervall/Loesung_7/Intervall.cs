using System;

namespace Uebung_Intervall
{
    class Intervall
    {
        private int max;
        private int min;

        public Intervall(int maximum, int minimum)
        {
            max = maximum;
            min = minimum;
        }

        public int Size()
        {
            return max - min;
        }

        public float Avg()
        {
            // Cast um Komma Zahl zu erhalten
            return (float)(max - min) / 2;
        }

        public void Move(int offset)
        {
            max += offset;
            min = min + offset;
        }

        public void Scale(int offset)
        {
            max *= offset;
            min = min * offset;
        }

        public void IntervallAusgabe(string methodenName)
        {
            Console.WriteLine(methodenName);
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}\n");
        }
    }
}
