using System;

namespace digitalis_nyomozo
{
    internal class Witness
    {
        private Person szemely;
        private string vallomasSzoveg;
        private DateTime vallomasDatum;

        public Witness(Person szemely, string vallomasSzoveg, DateTime vallomasDatum)
        {
            this.szemely = szemely;
            this.vallomasSzoveg = vallomasSzoveg;
            this.vallomasDatum = vallomasDatum;
        }

        public Person Szemely
        {
            get { return szemely; }
            set { szemely = value; }
        }

        public string VallomasSzoveg
        {
            get { return vallomasSzoveg; }
            set { vallomasSzoveg = value; }
        }

        public DateTime VallomasDatum
        {
            get { return vallomasDatum; }
            set { vallomasDatum = value; }
        }

        public override string ToString()
        {
            return szemely.Nev + " - Vallomás: " + vallomasSzoveg +
                   " (" + vallomasDatum.ToShortDateString() + ")";
        }
    }
}
