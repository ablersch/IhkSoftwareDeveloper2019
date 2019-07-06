using System;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Tier tierObjekt = new Tier();
            tierObjekt.GetNameUndAlter();
            Console.WriteLine("");

            tierObjekt = new Tier("Frosch");
            tierObjekt.GetNameUndAlter();

            Console.ReadLine();
        }
    }
}
