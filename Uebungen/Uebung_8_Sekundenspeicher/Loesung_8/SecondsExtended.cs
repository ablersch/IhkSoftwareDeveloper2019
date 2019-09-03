namespace Uebung_Sekundenspeicher
{
    class SecondsExtended {

        // immer den Rest zwischenspeichern und damit weiterrechnen
        private ulong rest;
        ulong temp;

        // Sekunden über die Eigenschaft setzen
        public ulong Seconds { get; set; }

        // Modulo (Division mit Rest)
        public ulong GetDays()
        {
            rest = Seconds % 86400;
            return Seconds / 86400;
        }

        public ulong GetHours()
        {
            // Temp Variable welche den Rest zwischenspeichert
            temp = rest;
            // Den neuen Restwert ermitteln und speichern
            rest = rest % 3600;
            // die vollen Stunden (60*60) zurückgeben
            return temp / 3600;
        }

        public ulong GetMinutes() {
            temp = rest;          
            rest = rest % 60;    
            return temp / 60;
        }

        public ulong GetSeconds()
        {
            return rest;
        }
    }
}
