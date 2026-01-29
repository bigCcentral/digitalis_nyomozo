using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalis_nyomozo
{
	internal class CaseStatus
	{
		private string aktualis_statusz;

		public CaseStatus(string aktualis_statusz)
		{
			this.aktualis_statusz = aktualis_statusz;
		}

		public string Aktualis_statusz { get => aktualis_statusz; set => aktualis_statusz = value; }
	}
}
