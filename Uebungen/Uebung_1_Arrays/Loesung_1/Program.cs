using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zeile = new int[] { 0, 1, 2, 3 };
            int[] spalte = new int[] { 5, 6, 7, 8, 9 };

            for (int i = 0; i < zeile.Length; i++)
            {
                Console.Write("Zeile [" + i + "]: ");
                for (int j = 0; j < spalte.Length; j++)
                {
                    Console.Write(zeile[i] * spalte[j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\nTaste drücken um zu beenden");
            Console.Read();
        }
    }
}
