using System;

namespace digitalis_nyomozo
{
    internal class Main
    {
        static void Main(string[] args)
        {
            DataStore store = new DataStore();
            EvidenceManager manager = new EvidenceManager(store.Evidences);

            while (true)
            {
                Console.WriteLine("\n1 - Bizonyíték hozzáadás");
                Console.WriteLine("2 - Bizonyíték törlés");
                Console.WriteLine("3 - Listázás");
                Console.WriteLine("0 - Kilépés");
                Console.Write("Választás: ");      string v = Console.ReadLine();
                if (v == "0")
                    break;
                if (v == "1")
                {
                    Console.Write("Azonosító: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Típus: ");
                    string tipus = Console.ReadLine();
                    Console.Write("Leírás: ");
                    string leiras = Console.ReadLine();
                    Console.Write("Megbízhatóság (1-5): ");
                    int m = int.Parse(Console.ReadLine());
                    manager.EvidenceHozzaadas(new Evidence(id, tipus, leiras, m));
                }
                else if (v == "2")
                {
                    Console.Write("Azonosító: ");
                    int id = int.Parse(Console.ReadLine());

                    manager.EvidenceTorles(id);
                }
                else if (v == "3")
                {
                    manager.EvidenceListazas();
                }
                else
                {
                    Console.WriteLine("Hibás választás!");
                }
            }

            Console.WriteLine("Kilépés...");
        }
    }
}
