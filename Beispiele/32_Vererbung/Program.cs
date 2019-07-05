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

            Console.ReadKey();
        }
    }


    class Lebewesen
    {
        // nur in den vererbenden Klassen verfügbar nicht von außerhalb
        private int alter;

        public Lebewesen(): this(5)  // Zugriff auf Konstruktor der selben Klasse
        {
            alter = 50;
            Console.WriteLine("Default Konstruktor Lebewesen Alter: " + alter);
        }

        public Lebewesen(int alterInput)
        {
            alter = alterInput;
            Console.WriteLine("Konstruktor Lebewesen Alter: " + alter);
        }

        public int GetAlter()
        {
            Console.WriteLine("GetAlter Lebewesen");
            return alter;
        }
    }


    class Tier : Lebewesen
    {
        // Attribut
        private string name;

        // Eigenschaft (Property) für das Attribut name
        public string NameEigenschaft
        {
            get { return name; }
            set
            {
                // Das Schlüsselwort "value" verweist auf den Wert, 
                // der der Eigenschaft vom Clientcode zugewiesen werden soll
                if (string.IsNullOrWhiteSpace(value))
                {
                    name = "Tier hat kein Name";
                }
                else
                {
                    name = value;
                }
            }
        }

        
        #region Konstruktoren

        public Tier() :base (5)  // Zugriff auf Konstruktor der Basisklasse
        {
            NameEigenschaft = "";   // nur noch zugreifen über die Eigenschaft
            Console.WriteLine("Default Konstruktor Tier");
        }

        public Tier(string name)
        {
            this.name = name;
            Console.WriteLine("Konstruktor Tier");
        }

        #endregion

        public string GetNameUndAlter()
        {
            int alter = GetAlter();  // Zugriff auf die Basisklasse
            Console.WriteLine("GetAlter Tier");
            return alter + NameEigenschaft;
        }        
    }
}
