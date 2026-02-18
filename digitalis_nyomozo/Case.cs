using System;
using System.Collections.Generic;
namespace digitalis_nyomozo
{
    internal class Case
    {
        private int azonosito;
        private string cim;
        private string leiras;
        private CaseStatus allapot;

        private List<Person> szemelyek;
        private List<Evidence> bizonyitekok;
        private List<TimelineEvent> idovonal;

        public Case(int azonosito, string cim, string leiras, CaseStatus allapot)
        {
            this.azonosito = azonosito;
            this.cim = cim;
            this.leiras = leiras;
            this.allapot = allapot;

            szemelyek =new List<Person>();
            bizonyitekok =new List<Evidence>();
            idovonal =new List<TimelineEvent>();
        }

        public int Azonosito { get => azonosito; set => azonosito = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public CaseStatus Allapot { get => allapot; set => allapot = value; }

        public List<Person> Szemelyek => szemelyek;
        public List<Evidence> Bizonyitekok => bizonyitekok;
        public List<TimelineEvent> Idovonal => idovonal;
    }
}
