using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalis_nyomozo
{
	internal class Suspect
	{
		private Person person;
		private int gyanusitottsagi_szint;
		private string statusz;

		public Suspect(Person person, int gyanusitottsagi_szint, string statusz)
		{
			this.person = person;
			this.gyanusitottsagi_szint = gyanusitottsagi_szint;
			this.statusz = statusz;
		}

		public int Gyanusitottsagi_szint { get => gyanusitottsagi_szint; set => gyanusitottsagi_szint = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Person Person { get => person; set => person = value; }
	}
}
