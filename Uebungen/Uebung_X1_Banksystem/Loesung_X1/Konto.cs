using System;
using System.Linq;

namespace Uebung_Banksystem
{
    public class Konto
    {
        private Kunde inhaber;
        private decimal kontostand;
        private decimal kreditlimit;
        private int kontonummer;
        private string bezeichnung;
        private decimal kredit;

        public Kunde Inhaber { get => inhaber; set => inhaber = value; }

        public int Kontonummer { get => kontonummer; }

        /// <summary>
        /// Eigenschaft wo beim schreiben der neue Geldeingang dem bestehenden Kontostand hinzugefügt/entfernt wird
        /// </summary>
        public decimal Kontostand
        {
            get
            {
                return kontostand;
            }

            set
            {
                kontostand += value;
            }
        }

        /// <summary>
        /// Eigenschaft in welcher beim schreiben des Kreditlimits auf das ALter des Inhabers geprüft wird
        /// </summary>
        public decimal Kreditlimit
        {
            get => kreditlimit;
            set
            {
                if (Inhaber.Alter < 18 && value > 0)
                {
                    kreditlimit = 0;
                    Console.WriteLine("Kreditlimit bei Kunden unter 18 Jahren darf nicht größer sein wie 0 €");
                }
                else
                {
                    kreditlimit = value;
                }
            }
        }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }

        /// <summary>
        /// Eigenschaft wo beim schreiben geprüft wird ob der neue Wert das Kreditlimit übersteigen könnte
        /// </summary>
        public decimal Kredit
        {
            get => kredit;
            set
            {
                if (kredit + value > Kreditlimit)
                {
                    Console.WriteLine($"Das Kreditlimit wäre mit dem neuen Kreditbetrag überschritten. Es ist noch maximal ein kredit von {Kreditlimit - kredit} möglich");
                }
                else
                {
                    kredit += value;
                }
            }
        }

        public Konto()
        {
            Inhaber = new Kunde();

            if (Inhaber.Alter < 18) Kreditlimit = 0;
            else Kreditlimit = 2000;

            Console.WriteLine("Bezeichnung:");
            Bezeichnung = Console.ReadLine();

            Random random = new Random();
            kontonummer = random.Next(100000, 999999);
        }

        // TODO eignes Menü wenn man ein bestimmtes Konto ausgewählt hat
        // TODO Kredit und Kontostand
       


        public void AusgabeKonto()
        {
            Console.WriteLine($"Kontonr: {Kontonummer}");
            Console.WriteLine($"Bezeichnung: { Bezeichnung}");
            Console.WriteLine($"Kreditlimit: { Kreditlimit}");
            Console.WriteLine($"Kontostand: { Kontostand}");
            Console.WriteLine("------------------");
        }

        /// <summary>
        /// Dynamisches Bearbeiten von allen Eigenschaften
        /// </summary>
        public void Bearbeiten()
        {
            // Von der aktuellen Klasse alle Eigenschaften abrufen
            var verfügbareEigenschaften = this.GetType().GetProperties().ToList();
            Console.WriteLine("Folgende Eigenschaften können verändert werden");
            foreach (var item in verfügbareEigenschaften)
            {
                Console.WriteLine("-" + item.Name);
            }

            Console.WriteLine("Welche Eigenschaft soll gesetzt werden");
            string eigenschaftName = Console.ReadLine();

            // Die zu bearbeitende Eigenschaft abrufen
            var eigenschaft = verfügbareEigenschaften.Where(x => x.Name == eigenschaftName).FirstOrDefault();

            Console.WriteLine("Welcher Wert soll gesetzt werden");
            string wert = Console.ReadLine();

            // Den Datentyp der Eigenschaft abrufen
            Type nodeType = eigenschaft.PropertyType;

            // Je nach Datentyp der Eigenschaft muss der zu setzende Wert anderst konvertiert werden
            if (nodeType == typeof(Decimal))
            {
                // Den neuen Wert der Eigenschaft zuweisen
                this.GetType().GetProperty(eigenschaftName).SetValue(this, Convert.ToDecimal(wert), null);
            }
            else if (nodeType == typeof(Int32))
            {
                this.GetType().GetProperty(eigenschaftName).SetValue(this, Convert.ToInt32(wert), null);
            } else
            {
                this.GetType().GetProperty(eigenschaftName).SetValue(this, wert, null);
            }
        }
    }
}
