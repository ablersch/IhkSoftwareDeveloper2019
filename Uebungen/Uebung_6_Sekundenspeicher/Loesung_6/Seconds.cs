namespace Uebung_Sekundenspeicher
{
    class Seconds
    {
        private ulong seconds;

        public Seconds(ulong seconds)
        {
            this.seconds = seconds;
        }

        public ulong GetSeconds()
        {
            return seconds;
        }

        public ulong GetMinutes()
        {
            return seconds / 60;
        }

        public ulong GetHours()
        {
            return seconds / 3600;
        }

        public ulong GetDays()
        {
            return seconds / (3600*24);
        }
    }
}
