using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterSix
{
	class ChapterSixOneExercises
	{
		Entry Entry = new Entry();

		public void UnosIspis()
		{
			Console.WriteLine("Napišite program koji traži unos 10 prirodnih brojeva i zatim ih ispisuje");
			List<int> brojevi = new List<int>();

			brojevi = Entry.ListOfNaturalNumbers(10);
			Console.WriteLine("\n");
			foreach(int br in brojevi)
			{
				Console.WriteLine(br);
			}

		}

		public void Max()
		{
			Console.WriteLine("Napišite program koji traži unos 5 prirodnih brojeva, a zatim ih ispisuje, s time da najveći ispisuje crvenom bojom.");
			List<int> brojevi = new List<int>();
			brojevi = Entry.ListOfNaturalNumbers(5);
			int MaxBroj = brojevi.Max();
			foreach(int br in brojevi)
			{
				if(br == MaxBroj)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(br);
					Console.ResetColor();
				}
				else
				{
					Console.WriteLine(br);
				}
			}

		}

		public void ZamjenaMjesta()
		{
			Console.WriteLine("Napišite program koji traži unos 10 prirodnih brojeva i zatim ih ispisuje, ali najvećem i najmanjem treba zamijeniti mjesta.");
			List<int> brojevi = new List<int>();
			brojevi = Entry.ListOfNaturalNumbers(5);
			int MinBroj = brojevi.Min();
			int MaxBroj = brojevi.Max();

			for(int i = 0; i < brojevi.Count(); i++)
			{
				if(brojevi[i] == MinBroj)
				{
					brojevi[i] = MaxBroj;
				}
				else if(brojevi[i] == MaxBroj)
				{
					brojevi[i] = MinBroj;
				}
				Console.WriteLine(brojevi[i]);
			}
		}

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(UnosIspis);
			Methods.Add(Max);
			Methods.Add(ZamjenaMjesta);

			return Methods;
		}
	}
}
