using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;
using System.Globalization;

namespace Algebra.Exercises.ChapterNine
{
	class ChapterNineOneExercises
	{
		Entry Entry = new Entry();
		Helpers Helpers = new Helpers();

		public void ZnakUrijeci()
		{
			Console.WriteLine("Napišite program koji traži unos jedne riječi i unos jednog znaka i zatim ispisuje koliko se puta taj znak pojavljuje u toj riječi.\n");

			string rijec = Entry.String("Unesi riječ:");
			int result = 0;
			string znak;

			while (true)
			{
				Console.WriteLine("Unesi znak:");
				znak = Console.ReadLine();
				if(znak.Length > 1)
				{
					Console.WriteLine("Krivi unos, probaj ponovno.");
				}
				else
				{
					break;
				}

			}


			for (int i = 0; i < rijec.Length; i++)
			{
				if (char.Parse(znak) == rijec[i])
				{
					result++;
				}
			}

			Console.WriteLine("Unešeni znak se pojavio " + result + " puta.");

		}

		public void RijecURecenici()
		{
			Console.WriteLine("Napišite program koji traži unos jedne rečenice i unos jedne riječi i zatim ispisuje koliko se puta ta riječ pojavljuje u toj rečenici.\n");

			string recenica = Entry.String("Unesi rečenicu:");

			string rijec = Entry.String("Unesi riječ:");
			string[] recenicaArray = recenica.Split(' ');
			int result = 0;

			foreach(string ri in recenicaArray)
			{
				if(rijec == ri)
				{
					result++;
				}
			}

			Console.WriteLine("Unesena riječ se spominje " + result + " puta.");
		}

		public void RijecUNoviRed()
		{
			Console.WriteLine("Napišite program koji traži unos rečenice i zatim ispisuje svaku riječ iz rečenice u novi red.\n");
			string recenica = Entry.String("Unesi rečenicu:");
			string[] recenicaArray = recenica.Split(' ');

			foreach(string rijec in recenicaArray)
			{
				Console.WriteLine(rijec);
			}
		}

		public void BrojanjeRijeci()
		{
			Console.WriteLine("Napišite program koji traži unos rečenice i zatim broji koliko ima riječi u toj rečenici.\n");

			string recenica = Entry.String("Unesi rečenicu:");
			string[] recenicaArray = recenica.Split(' ');
			Console.WriteLine("Unešena rečenica ima " + recenicaArray.Length + " riječi.");
		}

		public void KolikoPutaSePonavljaRijec()
		{
			Console.WriteLine("Napišite program koji traži unos rečenice i zatim broji koliko puta se pojavljuje koja riječ iz te rečenice. Program treba ignorirati velika i mala slova. \n");
			string recenica = Entry.String("Unesi rečenicu:").ToLower();
			string[] recenicaArray = recenica.Split(' ');
			List<string> ListaRijeci = new List<string>();
			foreach (string rijec in recenicaArray)
			{
				if (ListaRijeci.Contains(rijec))
				{
					continue;
				}
				Console.WriteLine(rijec + ":" + Helpers.BrojRijeciURecenici(rijec, recenicaArray) + " puta.");
				ListaRijeci.Add(rijec);
			}
		}

		public void Palindrom()
		{
			Console.WriteLine("Napišite program koji traži unos jedne linije teksta i zatim ispituje je li taj tekst palindrom (palindrom je riječ koje je ista čitamo li je s lijeve ili s desne strane). \n");
			char[] rijec = Entry.OneWord().ToCharArray();
			char[] RijecNaopako = new char[rijec.Length];
			Array.Copy(rijec, RijecNaopako, rijec.Length);
			Array.Reverse(RijecNaopako);

			bool Naopako = true;

			for(int i = 0; i < rijec.Length; i++)
			{
				if(rijec[i] != RijecNaopako[i])
				{
					Console.WriteLine("Riječ nije palindrom.");
					break;

				}
				else if(i == rijec.Length - 1)
				{
					Console.WriteLine("Riječ je palindrom!");
					break;
				}
			}


		
		}

		public void Osoba()
		{
			Osoba Osoba = new Osoba();
			Osoba.Ime = Entry.OneWord("Unesi ime:");
			Osoba.Prezime = Entry.OneWord("Unesi prezime:");

			Osoba.Pozdrav();

			Osoba.Inicijali();

			Osoba.Kapitalizacija();

			Console.WriteLine(Osoba.Ime + Osoba.Prezime);

		}

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(ZnakUrijeci);
			Methods.Add(RijecURecenici);
			Methods.Add(RijecUNoviRed);
			Methods.Add(BrojanjeRijeci);
			Methods.Add(KolikoPutaSePonavljaRijec);
			Methods.Add(Palindrom);
			Methods.Add(Osoba);

			return Methods;
		}
	}

	class Osoba
	{
		public string  Ime { get; set; }
		public string Prezime { get; set; }

		public void Pozdrav()
		{
			Console.WriteLine("Dobar dan, " + Ime);
		}

		public void Inicijali()
		{
			Console.WriteLine(Ime.First().ToString() + Prezime.First());
		}

		public void Kapitalizacija()
		{
			TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
			Ime = cultInfo.ToTitleCase(Ime);
			Prezime = cultInfo.ToTitleCase(Prezime);
		}
	}
}
