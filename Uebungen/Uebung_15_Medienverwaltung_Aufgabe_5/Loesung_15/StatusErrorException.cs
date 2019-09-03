using System;
using Logger;

namespace Medienverwaltung_Aufgabe_5
{
    class StatusErrorException : Exception
    {

        public StatusErrorException() : base()
        {
        }

        public StatusErrorException(string meldung) : base(meldung)
        {
            WriteToLog();
        }

        public StatusErrorException(string meldung, Exception exception)
            : base(meldung, exception)
        {
            WriteToLog();
        }

        public override string Message
        {
            get
            {
                return "Fehler beim Leihen/Rueckgeben von Signatur: " + base.Message;
            }
        }

        private void WriteToLog()
        {
            LoggerUtil.WriteLogToFile(Message, LoggerUtil.LogTyp.WARNING);
        }
    }
}
