using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3

{

	class SoinTherapeutique : Soin
	{
		private int codeSecu;

		//accesseurs à compléter  

		public int CodeSecu
		{
			get
			{ return this.codeSecu; }
			set
			{ this.codeSecu = value; }
		}


		//constructeur à
		public SoinTherapeutique(int leCode, string leLibelle, int leCodeTarif, int leCodeSS) : base(leCode, leLibelle, leCodeTarif)
		{
			this.codeSecu = leCodeSS;
		}
		//calcul du coût de base du soin
		public override double Couter()
		{
			Console.WriteLine("couter de soin therapeutique");
			return base.Couter() - (this.codeSecu * Soin.PointTarif);
		}

		public override string ToString()
		{
			return base.ToString() + " pour le code secu " + this.codeSecu;
		}
	}
}
