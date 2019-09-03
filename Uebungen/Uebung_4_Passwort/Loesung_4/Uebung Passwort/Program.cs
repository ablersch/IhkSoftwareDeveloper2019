using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Passwort
{
    class Program
    {
        static string password;

        static void Main(string[] args)
        {
            PasswordInput();

            Console.ReadLine();
        }

        /// <summary>
        /// Masking password input
        /// </summary>
        private static void PasswordInput()
        {
            Console.WriteLine("Passwort eingeben: ");
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                // Möglichkeit bieten falsche Eingabe zu korrigieren
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                {
                    // Den gedrücketen Buchstaben dem Password string hinzufügen
                    password += keyInfo.KeyChar;
                    // Darstellung als Platzhalter mit *
                    Console.Write("*");
                }
                else
                {
                    if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        // letztes Zeichen entfernen
                        password = password.Substring(0, (password.Length - 1));
                        // 2 mal (Backspace Taste und das letzte Zeichen) zurück (Backspace)
                        Console.Write("\b \b");
                    }
                }
            }
            // Wenn Enter gedrückt wurde die Passwort Abfrage beenden
            while (keyInfo.Key != ConsoleKey.Enter);
        }
    }
}
