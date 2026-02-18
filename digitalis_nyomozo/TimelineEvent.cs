using System;

namespace digitalis_nyomozo
{
    internal class TimelineEvent
    {
        private DateTime datum;
        private string esemenyLeiras;

        public TimelineEvent(DateTime datum, string esemenyLeiras)
        {
            Datum = datum;
            EsemenyLeiras = esemenyLeiras;
        }

        public DateTime Datum
        {
            get => datum;
            set => datum = value;
        }

        public string EsemenyLeiras
        {
            get => esemenyLeiras;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Az esemény leírása nem lehet üres.");
                esemenyLeiras = value;
            }
        }

        public override string ToString()
        {
            return $"{Datum.ToShortDateString()},{EsemenyLeiras}";
        }
    }
}
