using System;
using System.Collections;
using System.Collections.Generic;

namespace Medienauswahl_Aufgabe_3
{
    static class Data
    {
        private static Dictionary<int,Medien> medienDic = new Dictionary<int, Medien>();

        /// <summary>
        /// Daten speichern
        /// </summary>
        /// <param name="key">ID des Elements</param>
        /// <param name="data">Das zu speichernde Datenobjekt</param>
        internal static void AddData(int key, Medien data)
        {
            medienDic.Add(key, data);
        }

        /// <summary>
        /// Prüfen ob die ID/Key eindeutig ist
        /// </summary>
        /// <param name="key">Zu prüfende ID</param>
        /// <returns>true = id erlaubt; false = id nicht erlaubt</returns>
        internal static bool IsKeyEindeutig(int key)
        {
            if (medienDic.ContainsKey(key))
            {
                Console.WriteLine("Signatur existiert bereits");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Gibt alle Elemente zurück
        /// </summary>
        /// <returns>Eine ArrayList das alle Elemente beinhaltet</returns>
        internal static ArrayList GetAllElements()
        {
            ArrayList arrayList = new ArrayList();

            foreach (var medien in medienDic)
            {
                arrayList.Add(medien.Value);
            }

			// alternativ
            //List<Medien> medienList = medienDic.Values.ToList();
			
            return arrayList;
        }

        /// <summary>
        /// Holt ein Element
        /// </summary>
        /// <param name="key">ID/Key des Elements</param>
        /// <returns>Wurde das Element gefunden wird das Object zurückgegebene, ansonsten null</returns>
        internal static Medien GetElement(int key)
        {
            if (medienDic.ContainsKey(key))
            {
                return medienDic[key];
            }
            else
            {
                Console.WriteLine("Signatur nicht gefunden!");
                return null;
            }
        }

        /// <summary>
        /// Löscht ein Element
        /// </summary>
        /// <param name="key">ID/Key des Elements</param>
        internal static void DeleteElement(int key)
        {
            if (medienDic.ContainsKey(key))
            {
                medienDic.Remove(key);
                Console.WriteLine($"Medium mit der Signatur: {key} erfolgreich gelöscht.");
            }
        }
    }
}
