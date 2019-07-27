// Verweis auf die DLL hinzufügen
// Namespace unseres Loggers verwenden
using System;
using Uebung_Logger;

namespace Logger_verwenden
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logger aufrufen
            LoggerUtil.SetLoggerPath("c:\\temp\\test123", "fileLog.txt");

            // Logtext schreiben
            LoggerUtil.WriteLogToFile("Erster Eintrag", LoggerUtil.LogTyp.LOW);
            LoggerUtil.WriteLogToFile("Fehler bei ...", LoggerUtil.LogTyp.ERROR);

            Console.ReadLine();
        }
    }
}
