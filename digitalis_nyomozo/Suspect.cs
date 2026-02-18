using digitalis_nyomozo;

internal class Suspect
{
    private Person person;
    private int gyanusitottsagi_szint;
    private string statusz;

    public Suspect(Person person, int gyanusitottsagi_szint, string statusz)
    {
        this.person = person;
        Gyanusitottsagi_szint = gyanusitottsagi_szint;
        Statusz = statusz;
    }

    public int Gyanusitottsagi_szint
    {
        get => gyanusitottsagi_szint;
        set
        {
            if (value < 0)
                gyanusitottsagi_szint = 0;
            else if (value > 100)
                gyanusitottsagi_szint = 100;
            else
                gyanusitottsagi_szint = value;
        }
    }

    public string Statusz
    {
        get => statusz;
        set
        {
            if (value == "Szabad" || value == "Megfigyelt" || value == "Orizetben")
                statusz = value;
            else
                Console.WriteLine("Érvénytelen státusz!");
        }
    }

    internal Person Person { get => person; set => person = value; }
}