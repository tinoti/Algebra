using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterEight
{
	class ChapterEightOneExercises
	{
		Entry Entry = new Entry();

		public void Proizvod()
		{
			Proizvod proizvod = new Proizvod();

			Console.WriteLine("Naziv:");
			proizvod.Naziv = Console.ReadLine();

			proizvod.Cijena = (double)Entry.DecimalNumber("Cijena:");

			proizvod.Marza = (double)Entry.DecimalNumber("Marza");

			proizvod.Porez = (double)Entry.DecimalNumber("Porez");

			Console.WriteLine("MPC je: " + proizvod.MPC());
		}

		public void Automobil()
		{

		}

		public void Zaposlenik()
		{

		}


		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Proizvod);
			Methods.Add(Automobil);
			Methods.Add(Zaposlenik);

			return Methods;
		}
	}
}
