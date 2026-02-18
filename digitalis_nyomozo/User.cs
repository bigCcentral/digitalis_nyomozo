namespace digitalis_nyomozo
{
    internal class User
    {
        private string nev;
        private int azonosito;
        private string szerepkor;
        public User(string nev, int azonosito, string szerepkor)
        {
            this.nev = nev;
            this.azonosito = azonosito;
            this.szerepkor = szerepkor;
        }
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        public int Azonosito
        {
            get { return azonosito; }
            set { azonosito = value; }
        }
        public string Szerepkor
        {
            get { return szerepkor; }
            set { szerepkor = value; }
        }
        public override string ToString()
        {
            return azonosito + " _ " + nev + " (" + szerepkor + ")";
        }
    }
}
