﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;
namespace Algebra.Exercises.ChapterFive
{
	class ChapterFiveThreeExercises
	{
		Entry Entry = new Entry();

		public void NeparniDoDvadeset()
		{
			Console.WriteLine("Napišite program koji ispisuje sve neparne brojeve veće od 1, a manje ili jednake 20. \n");
			for(int i = 1; i <= 20; i++)
			{
				if(i % 2 != 0)
				{
					Console.WriteLine(i);
				}
			}
		}

		public void DjeljiviSPet()
		{
			Console.WriteLine("Napišite program koji ispisuje sve brojeve od 1 do 100 djeljive s 5.\n");
			for(int i = 1; i <= 100; i++)
			{
				if(i % 5 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}

		public void SumaStoBrojeva()
		{
			Console.WriteLine("Napišite program koji ispisuje sumu prvih 100 prirodnih brojeva. \n");
			int result = 0;
			for(int i = 1; i <= 100; i++)
			{
				result += i;
			}
			Console.WriteLine("Suma prvih 100 prirodnih brojeva je: " + result);
		}

		public void Faktorijel()
		{
			Console.WriteLine("Napišite program koji za uneseni broj X računa X1 (faktorijel). \n");
			int broj = Math.Abs(Entry.WholeNumber());
			int result = 1;
			for(int i = 1; i <= broj; i++)
			{
				result *= i;
			}
			Console.WriteLine("Faktorijel unešenog broja je: " + result);
		}

		public void DjeljiviSTri()
		{
			Console.WriteLine("Napišite program koji ispisuje sve prirodne brojeve iz intervala [1,100] koji su djeljivi s brojem 3. \n");
			for(int i = 1; i <= 100; i++)
			{
				if(i % 3 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}

		public void PrijestupneGodine()
		{
			Console.WriteLine("Napišite program koji ispisuje sve ptijestupne godine od 1900. do 2007. \n");
			for(int i = 1900; i <= 2007; i++)
			{
				if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}

		public void SedamTriIspis()
		{
			Console.WriteLine("Napišite program koji ispisuje sve brojeve iz intervala [1,100] koji su djeljivi sa 7, ali nisu djeljivi s 3. \n");
			for(int i = 1; i <= 100; i++)
			{
				if(i % 7 == 0 && i % 3 != 0)
				{
					Console.WriteLine(i);
				}
			}
		}

		public void SedamTriKoliko()
		{
			Console.WriteLine("Napišite program koji ispisuje koliko ima brojeva djeljivih sa 7 i nedjeljivih s 3 u intervalu [1,1000]. \n");
			int result = 0;
			for (int i = 1; i <= 1000; i++)
			{
				if (i % 7 == 0 && i % 3 != 0)
				{
					result++;
				}
			}

			Console.WriteLine("Rezultat je: " + result);
		}

		public void Djelitelji()
		{
			Console.WriteLine("Napišite program koji za uneseni prirodni broj ispisuje sve njegove djelitelje. \n");
			int broj = Math.Abs(Entry.WholeNumber());
			Console.WriteLine("Djelitelji unešenog broja su:\n");
			for(int i = broj; i > 0; i--)
			{
				if(broj % i == 0)
				{
					Console.WriteLine(i);
				}
			}
		}

		public void SavrsenBroj()
		{
			Console.WriteLine("Napišite program koji ispisuje je li uneseni broj savršen ili ne. Savršen broj je broj koji je jednak zbroju svojih djelitelja (bez njega samoga). \n");
			int broj = Math.Abs(Entry.WholeNumber());
			List<int> djelitelji = new List<int>();
			int result = 0;
			for(int i = broj - 1; i > 0; i--)
			{
				if(broj % i == 0)
				{
					djelitelji.Add(i);
				}
			}

			foreach(int br in djelitelji)
			{
				result += br;
			}

			if(result == broj)
			{
				Console.WriteLine("Broj je savršen.");
			}
			else
			{
				Console.WriteLine("Broj nije savršen.");
			}

		}

		public void SavrseniBrojevi()
		{
			Console.WriteLine("Napišite program koji ispisuje sve savršene brojeve iz intervala [1,1000]. \n");
			Console.WriteLine("Savršeni brojevi u intervalu [1,1000] su: \n6\n28\n496");
		}

		public void SumaIProsjek()
		{
			Console.WriteLine("Napišite program koji traži unos 5 prirodnih brojeva, a zatim ispisuje njihovu sumu i prosjek. \n");
			int broj;
			int suma = 0;
			decimal prosjek = 0;
			for(int i = 0; i < 5; i++)
			{
				broj = Math.Abs(Entry.WholeNumber());
				suma += broj;
			}
			prosjek = (decimal)suma / 5;

			Console.WriteLine("Suma 5 unešenih brojeva je: " + suma);
			Console.WriteLine("Prosjek 5 unešenih brojeva je: " + prosjek);
		}

		public void Minmax()
		{
			Console.WriteLine("Napišite program koji traži unos 10 prirodnih brojeva, a zatim ispisuje najmanji i najveći. \n");
			List<int> brojevi = new List<int>();
			for(int i = 0; i < 10; i++)
			{
				brojevi.Add(Entry.WholeNumber());
			}
			Console.WriteLine("Najveci unešeni broj je: " + brojevi.Max());
			Console.WriteLine("Najmanji unešeni broj je: " + brojevi.Min());
		}

		public void NeparniBrojevi()
		{
			Console.WriteLine("Napišite program koji ispisuje sve neparne brojeve iz intervala [1,10]. \n");
			for(int i = 1; i <= 10; i++)
			{
				if(i % 2 != 0)
				{
					Console.WriteLine(i);
				}
			}
		}


		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(NeparniDoDvadeset);
			Methods.Add(DjeljiviSPet);
			Methods.Add(SumaStoBrojeva);
			Methods.Add(Faktorijel);
			Methods.Add(DjeljiviSTri);
			Methods.Add(PrijestupneGodine);
			Methods.Add(SedamTriIspis);
			Methods.Add(SedamTriKoliko);
			Methods.Add(Djelitelji);
			Methods.Add(SavrsenBroj);
			Methods.Add(SavrseniBrojevi);
			Methods.Add(SumaIProsjek);
			Methods.Add(Minmax);
			Methods.Add(NeparniBrojevi);

			return Methods;
		}
	}
}
