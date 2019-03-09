using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterSix
{
	class ChapterSixTwoExercises
	{
		Entry Entry = new Entry();
		public void Naopako()
		{
			Console.WriteLine("Napišite program koji traži unos 10 prirodnih brojeva a zatim ih ispisuje naopako.");

			List<int> brojevi = new List<int>();
			brojevi = Entry.ListOfNaturalNumbers(10);
			brojevi.Reverse();

			foreach(int br in brojevi)
			{
				Console.WriteLine(br);
			}
		}

		public void ParNeparDva()
		{
			Console.WriteLine("Napišite program koji traži unos 10 prirodnih brojeva i parne i neparne brojeve sprema odvojeno, u dva objekta klase List<int> i zatim ispisuje te dvije kolekcije brojeva.\n");

			List<int> brojevi = Entry.ListOfNaturalNumbers(10);
			List<int> NeparniBrojevi = new List<int>();
			List<int> ParniBrojevi = new List<int>();
			
			foreach(int broj in brojevi)
			{
				if(broj %2 == 0)
				{
					ParniBrojevi.Add(broj);
				}
				else
				{
					NeparniBrojevi.Add(broj);
				}
			}

			Console.WriteLine("Parni brojevi su:");
			foreach(int broj in ParniBrojevi)
			{
				Console.WriteLine(broj);
			}

			Console.WriteLine("Neparni brojevi su:");
			foreach(int broj in NeparniBrojevi)
			{
				Console.WriteLine(broj);
			}
		}

		public void Sort()
		{
			Console.WriteLine("Napišite program koji traži unos prirodnih brojeva dok se ne uneses 0 i zatim ispisuje unesene brojeve poredane prema veličini.\n");

			List<int> brojevi = Entry.ListOfNaturalNumbers();
			brojevi.Sort();

			foreach(int broj in brojevi)
			{
				Console.WriteLine(broj);
			}
		}

		public void Znamenke()
		{
			Console.WriteLine("Napišite program koji traži unos prirodnog broja, a zatim znamenke upisanog broja ispisuje naopako.\n");

			int broj = Entry.NaturalNumber();
			char[] CharBroj = broj.ToString().ToCharArray();
			Array.Reverse(CharBroj);
			Console.WriteLine(CharBroj);
		}

		public void ProstiFaktori()
		{
			Console.WriteLine("Napišite program koji traži unos prirodnog broja, a zatim ispisuje rastav broja na proste faktore.");

			int broj = Entry.NaturalNumber();
			List<int> Faktori = new List<int>();

			int faktor = 2;

			while(faktor <= broj)
			{
				if(broj % faktor == 0)
				{
					Faktori.Add(faktor);
					broj /= faktor;
				}
				else
				{
					faktor++;
				}
			}
			Console.WriteLine("\nProsti faktori su:");
			foreach(int fk in Faktori)
			{
				
				Console.WriteLine(fk);
				
			}
		}

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Naopako);
			Methods.Add(ParNeparDva);
			Methods.Add(Sort);
			Methods.Add(Znamenke);
			Methods.Add(ProstiFaktori);

			return Methods;
		}
	}
}
