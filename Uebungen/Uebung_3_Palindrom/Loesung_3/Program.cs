using System;
using System.Linq;

namespace Uebung_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrom-Test");
            Console.WriteLine("Geben sie bitte das zu pruefende Wort ein: ");

            string wort = Console.ReadLine();

            bool isPalindrom = IsPalindrom(wort);

            if (isPalindrom)
            {
                Console.WriteLine($"Das Wort {wort} ist ein Palindrom\n");
            }
            else
            {
                Console.WriteLine($"Das Wort {wort} ist kein Palindrom\n");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Prüfen ob der Input ein Palindrom ist
        /// </summary>
        /// <param name="checkForPalindrom">Zu prüfender Wert</param>
        /// <returns>true = ist ein Palindrom; false = kein Palindrom</returns>
        private static bool IsPalindrom(string checkForPalindrom)
        {
            string wortReverse = string.Empty;

            // Entferne alle Leerzeichen
            checkForPalindrom = checkForPalindrom.Replace(" ", "");

            // Alles in Kleinbuchstaben
            checkForPalindrom = checkForPalindrom.ToLower();

            // String spiegeln mit Schleife (von vorne)
            for (int i = 0; i < checkForPalindrom.Length; i++)
            {
                wortReverse = wortReverse + checkForPalindrom[checkForPalindrom.Length - i - 1];
            }

            // String spiegeln mit Schleife (vom Ende beginnend den String durchgehen)
            //for (int i = checkForPalindrom.Length - 1; i >= 0; i--)
            //{
            //    wortReverse = wortReverse + checkForPalindrom[i];
            //}

            // Alternative 1
            // Einzelne Zeichen vom Anfang und vom Ende beginnend vergleichen
            //int leftIndex = 0;
            //int rightIndex = checkForPalindrom.Length - 1;

            //while (leftIndex < rightIndex)
            //{
            //    if (checkForPalindrom[leftIndex] != checkForPalindrom[rightIndex])
            //    {
            //        return false; // kein Palindorm
            //    }
            //    leftIndex++;
            //    rightIndex--;
            //}

            // Alternative 2
            //wortReverse = ReverseString(checkForPalindrom);

            // Alternative 3
            // String in ein Array wandeln, dieses Array spiegeln
            // wieder in ein Array wandeln und über String Konstruktor neuen String erstellen
            // wortReverse = new string(checkForPalindrom.ToCharArray().Reverse().ToArray());

            if (checkForPalindrom == wortReverse)
            {
                return true;  // ist ein Palindrom
            }
            else
            {
                return false; // ist kein Palindrom
            }
        }

        /// <summary>
        /// String umdrehen mit Array
        /// </summary>
        /// <param name="s">String der umgedreht werden soll</param>
        /// <returns>Gibt umgedrehten String zurück</returns>
        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
