using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalis_nyomozo
{
	internal class Witness
	{
		private Person vallomas_szoveg;
		private int vallomas_datum;

		public Witness(Person vallomas_szoveg, int vallomas_datum)
		{
			this.vallomas_szoveg = vallomas_szoveg;
			this.vallomas_datum = vallomas_datum;
		}

		public int Vallomas_datum { get => vallomas_datum; set => vallomas_datum = value; }
		internal Person Vallomas_szoveg { get => vallomas_szoveg; set => vallomas_szoveg = value; }
	}
}
