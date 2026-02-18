using System;

namespace digitalis_nyomozo
{
    internal class Person
    {
        private string nev;
        private int eletkor;
        private string megjegyzes;

        public Person(string nev, int eletkor, string megjegyzes)
        {
            Nev = nev;
            Eletkor = eletkor;
            Megjegyzes = megjegyzes;
        }

        public string Nev
        {
            get => nev;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A név nem lehet üres.");
                nev = value;
            }
        }

        public int Eletkor
        {
            get => eletkor;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Az életkor nem lehet negatív.");//AI segitett benne 
                eletkor = value;
            }
        }

        public string Megjegyzes
        {
            get => megjegyzes;
            set => megjegyzes = value;
        }

        public override string ToString()
        {
            return $"{Nev} ({Eletkor} év) - {Megjegyzes}";
        }
    }
}
