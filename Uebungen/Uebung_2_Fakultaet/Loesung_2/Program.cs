using System;

namespace Übung_Fakultät
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fakultät berechnen");
            Console.Write("Bitte eine Zahl eingeben: ");

            string input = Console.ReadLine();
            ulong number = Convert.ToUInt64(input);

            ulong result = 1;

            if (number >= 0)
            {
                for (ulong i = 1; i <= number; i++)
                {
                    result = result * i;
                    //result *= i;
                }
            }
            else
            {
                result = 0;
            }

            Console.WriteLine($"Die Fakultät der Zahl {number} ist: {result}");
            Console.WriteLine("\nTaste drücken um zu beenden");
            Console.ReadLine();
        }
    }
}
