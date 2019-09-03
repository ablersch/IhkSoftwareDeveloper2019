using System;
using System.IO;

namespace Uebung_Logger
{
    public static class LoggerUtil
    {
        private static string logFilePath;
        private static string logFolderPath;

        private const int MAX_LOG_SIZE = 5242880;  // 5MB  -> 5 byte * 1024 = kbyte * 1024 = mbyte

        public static string LogFilePath
        {
            get { return logFilePath; }
        }

        private static string LogFolderPath
        {
            get { return logFolderPath; }
            set { logFolderPath = value; }
        }

        public enum LogTyp
        {
            WARNING,
            CRITICAL,
            ERROR,
            LOW,
            HIGH
        };

        /// <summary>
        /// Pfade und Logfile setzen. Wenn Objekt nicht existiert erstellen
        /// </summary>
        /// <param name="logFolderPath">Ordner wo die Logdatei gespeichert wird</param>
        /// <param name="logFileName">Name der Logdatei</param>
        public static void SetLoggerPath(string logFolderPath, string logFileName)
        {
            LogFolderPath = logFolderPath;

            // Prüfen ob eine Dateiendung angegeben wurde
            if (logFileName.Contains("."))
            {
                logFilePath = Path.Combine(LogFolderPath, logFileName);
            }
            else
            {
                // Wenn nicht Endung auf txt setzen
                logFilePath = Path.Combine(LogFolderPath, logFileName + ".txt");
            }

            try
            {
                // Verzeichnis erstellen, falls nicht vorhanden
                if (!Directory.Exists(logFolderPath))
                {
                    Directory.CreateDirectory(logFolderPath);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Write log files
        /// </summary>
        /// <param name="logText">Log message</param>
        /// <param name="logTyp">Enum typ</param>
        public static void WriteLogToFile(string logText, LogTyp logTyp)
        {
            bool deleteFile = false;
            try
            {
                if (!string.IsNullOrWhiteSpace(LogFilePath))
                {
                    // Neuer Eintrag mit Zeit, LogTyp und Text
                    logText = $"{DateTime.Now} - {logTyp} : {logText}";

                    // Datei erstellen, falls nicht vorhanden
                    using (StreamWriter writer = new StreamWriter(LogFilePath, true))
                    {
                        writer.WriteLine(logText);

                        // StreamWriter schreibt nicht sofort
                        writer.Flush();

                        if (writer.BaseStream.Length > MAX_LOG_SIZE)
                        {
                            // löschen direkt nicht möglich da Datei noch vom StreamWriter geöffnet ist!!
                            deleteFile = true;
                        }
                    }

                    if (deleteFile == true) File.Delete(LogFilePath);
                }
                else
                {
                    Console.WriteLine("Bitte zuerst den Pfad und die Logdatei festlegen");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Fehler beim schreiben. Fehler: {e.Message}");
            }
        }
    }
}
