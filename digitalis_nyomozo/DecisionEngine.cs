using System;
using System.Collections.Generic;

namespace digitalis_nyomozo
{
    internal class DecisionEngine
    {
        public void Ertekeles(Suspect gyanusitott, List<Evidence> bizonyitekok)
        {
            int osszeg = 0;

            foreach (var b in bizonyitekok)
            {
                osszeg += b.Megbizhatosag;
            }

            gyanusitott.GyanusitottsagiSzint += osszeg * 5;

            Console.WriteLine($"Új gyanúsítottsági szint: {gyanusitott.GyanusitottsagiSzint}");

            if (gyanusitott.GyanusitottsagiSzint >= 70)
            {
                Console.WriteLine("FIGYELEM! A gyanúsított elérte a veszélyes küszöbértéket!");
            }
        }
    }
}