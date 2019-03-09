using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterSeven
{
	class ChapterSevenOneExercises
	{
		Entry Entry = new Entry();
		Helpers Helpers = new Helpers();
		public void Zbroj()
		{
			
			Console.WriteLine("Napišite program koji traži unos dva broja i ispisuje njihov zbroj. Zadatak riješite pomoću potprograma. \n");

			int PrviBroj = Entry.WholeNumber();
			int DrugiBroj = Entry.WholeNumber();

			Console.WriteLine("Zbroj dvaju unešenih broja je: " + (PrviBroj + DrugiBroj));
		}

		public void Hipotenuza()
		{
			Console.WriteLine("Napišite program koji traži unos duljina dviju kateta pravokutnog trokuta i zatim u potprogramu ispisuje duljinu hipotenuze. \n");

			int KatetaJedan = Entry.NaturalNumber("Unesi duljinu prve katete");
			int KatetaDva = Entry.NaturalNumber("Unesi duljinu druge katete");

			Helpers.Pitagorin(KatetaJedan, KatetaDva);
		}

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Zbroj);
			Methods.Add(Hipotenuza);

			return Methods;
		}
	}
}
