using System;
using System.IO;

namespace Uebung_Dateien_ausgeben
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prüfen ob Befehlszeilenargumente vorhanden sind
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    // Argument holen
                    string pfad = args[i];

                    // Prüfen ob Datei existiert
                    if (File.Exists(pfad))
                    {
                        // Prüfen ob Endung vorhanden
                        if (pfad.Contains("."))
                        {
                            // Datei aufteilen in Name und Dateiendung
                            string[] endung = pfad.Split('.');

                            if (endung[endung.Length - 1] == "log" || endung[endung.Length - 1] == "txt")
                            {
                                DateiAusgabe(pfad);
                            }
                            else
                            {
                                Console.WriteLine($"Die Endung {endung[endung.Length - 1]} wird nicht unterstützt");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Die Datei {pfad} existiert nicht");
                    }
                }
            }
            else
            {
                Console.WriteLine("Kein Parameter mitgegeben");
            }
            Console.WriteLine("\nZum beenden Taste drücken");
            Console.ReadLine();
        }

        private static void DateiAusgabe(string pfad)
        {
            FileInfo fileInfo = new FileInfo(pfad);

            // Damit keine Kommastelle verloren geht
            float lengthInKb = fileInfo.Length / 1024f;

            Console.WriteLine("\n---------------");
            Console.WriteLine($"Datei: {pfad}");
            Console.WriteLine($"Größe [KB]: {lengthInKb} Erstelldatum: {fileInfo.CreationTime.ToShortDateString()} letzte Änderung: {fileInfo.LastWriteTime}");
            Console.WriteLine();

            try
            {
                using (StreamReader streamReader = fileInfo.OpenText())
                {
                    string line;
                    // Solange lesen, solange nicht null zurück kommt
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.Contains("ERROR"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (line.Contains("WARNING"))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (line.Contains("HIGH"))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            // Normal, ohne Farbe ausgeben
                            Console.ResetColor();
                        }

                        Console.WriteLine(line);
                    }
                }
                Console.ResetColor();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
