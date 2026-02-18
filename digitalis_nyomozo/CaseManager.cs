using System;
using System.Collections.Generic;
using System.Linq;

namespace digitalis_nyomozo
{
    internal class CaseManager
    {
        private List<Case> cases;

        public CaseManager()
        {
            cases = new List<Case>();
        }

        public void UjUgyLetrehozasa(Case ujCase)
        {
            cases.Add(ujCase);
            Console.WriteLine("Ügy sikeresen letrehozva");
        }

        public void UgyekListazasa()
        {
            if (cases.Count == 0)
            {
                Console.WriteLine("Nincs rögzített ügy");
                return;
            }
        }

    }
}
