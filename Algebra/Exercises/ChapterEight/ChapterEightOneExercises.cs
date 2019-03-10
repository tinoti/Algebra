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
			Automobil automobil = new Automobil();
			Console.WriteLine("Marka:");
			automobil.MarkaAutomobila = Console.ReadLine();

			automobil.KS = (double)Entry.DecimalNumber("KS: ");

			automobil.OsnovnaCijena = (double)Entry.DecimalNumber("Osnovna cijena: ");

			Console.WriteLine("Porez: " + automobil.IznosPoreza());

			Console.WriteLine("Ukupna cijena: " + automobil.UkupnaCijena());
		}

		public void Zaposlenik()
		{
			Console.WriteLine("Ime:");
			string Ime = Console.ReadLine();

			Console.WriteLine("Prezime:");
			string Prezime = Console.ReadLine();

			Console.WriteLine("JMBG:");
			string JMBG = Console.ReadLine();

			int BrojBodova = Entry.NaturalNumber("Broj bodova: ");

			double VrijednostBoda = (double)Entry.DecimalNumber("Vrijednost boda: ");

			Zaposlenik zaposlenik = new Zaposlenik(Ime, Prezime, JMBG, BrojBodova, VrijednostBoda);

			Console.WriteLine("Neto plaća: " + zaposlenik.NetoIzracunPlace());
			Console.WriteLine("Bruto plaća: " + zaposlenik.BrutoIzracunPlace());
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
