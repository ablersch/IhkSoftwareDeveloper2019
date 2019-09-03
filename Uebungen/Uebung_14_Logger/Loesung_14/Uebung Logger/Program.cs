using System;

namespace Uebung_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logger");
            LoggerUtil.SetLoggerPath(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\test", "abcd");

            LoggerUtil.WriteLogToFile("das ist ein logger text1", LoggerUtil.LogTyp.ERROR);
            LoggerUtil.WriteLogToFile("das ist ein logger text2", LoggerUtil.LogTyp.WARNING);
            LoggerUtil.WriteLogToFile("das ist ein logger text3", LoggerUtil.LogTyp.ERROR);

            Console.ReadLine();
        }
    }
}
