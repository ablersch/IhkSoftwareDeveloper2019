using System;

namespace Vererbung_virtual_override {

    class Program {

        static void Main(string[] args)
        {
            Lebewesen lebeObjekt;
            // Fehler da Klasse abstract ist -> kein erstellen einer Instanz möglich
            // lebeObjekt = new Lebewesen();

            // Aufruf abfolge?
            Tier tierObjekt = new Tier();

            // Zuweisung erlaubt da von Basisklasse abgeleitet
            lebeObjekt = tierObjekt;

            // es wird immer die letzte überschriebene Methode aufgerufen
            tierObjekt.Output();
            lebeObjekt.Output();

            // je nach Datentyp wird die überdeckte Methode oder die der Basisklasse aufgerufen
            tierObjekt.GetAlter();
            lebeObjekt.GetAlter();

            Console.ReadLine();
        }
    }



    abstract class Lebewesen
    {
        // nur in den vererbenden Klassen verfügbar nicht von außerhalb
        protected int alter;

        // Muss in der Kindklasse definiert werden
        public abstract string GetString();

        public Lebewesen() 
        {
            alter = 5;
        }

        public int GetAlter()
        {
            Console.WriteLine($"GetAlter Lebewesen {GetString()}");
            return alter;
        }

        // Methode wird als überschreibbar gekennzeichnet
        public virtual void Output()
        {
            Console.WriteLine("Output Lebewesen");
        }
    }


    sealed class Tier : Lebewesen
    {
        // Methode der Basisklasse wird überdeckt
        // Je nach Datentyp wird diese oder die Methode der Basisklasse aufgerufen
        public new int GetAlter()
        {
            Console.WriteLine("GetAlter Tier (überdeckt)");
            return alter;
        }

        // Methode der Basisklasse wird überschrieben
        public override void Output()
        {
            alter = 5;
            Console.WriteLine("Output Tier (überschrieben)");
            GetAlter();
        }

        // Muss implementiert werden, da dies in der Baisklasse mit "abstract" vorgegeben wurde
        public override string GetString()
        {
            return "1234";
        }
    }

    class Mensch : Lebewesen
    {
        public override string GetString()
        {
            return "123";
        }
    }
}
