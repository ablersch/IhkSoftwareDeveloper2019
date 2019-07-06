using System;

namespace Vererbung
{
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

        public Tier() //:base (5)  // Zugriff auf Konstruktor der Basisklasse
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
            return $"Alter: {alter} Name: {NameEigenschaft}";
        }        
    }
}
