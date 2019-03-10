using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterEleven
{
	class ChapterElevenOneExercises
	{
		Entry Entry = new Entry();

		public void Imena()
		{
			Console.WriteLine("Napišite program koji traži unos imena sve dok se ne unese riječ 'kraj'. Na konzolni prozor neka ispiše sva imena koja u sebi sadrže slovo 'a'. Program mora podržavati velika i mala slova.\n");

			List<string> Imena = new List<string>();
			string imena;

			while (true)
			{
				Console.WriteLine("Unesite ime, za kraj unesite kraj: ");
				imena = Console.ReadLine().ToUpper();
				if (imena == "KRAJ")
				{
					break;
				}
				else
				{
					Imena.Add(imena);
				}

			}

			var imenaSaSlovomA = (from ime in Imena where ime.Contains("A") select ime).ToList();
			foreach(string ime in imenaSaSlovomA)
			{
				Console.WriteLine(ime);
			}
		}

		public void PrviDirektorij()
		{
			Console.WriteLine("Napišite program koji traži unos putanje i ispisuje naziv prvog pronađenog direktorija na putanji po abecednom redu, silazno. Program ne smije prijaviti grešku ako nije pronađen niti jedan direktorij.\n");
			Console.WriteLine("Upišite putanju: ");
			string putanja = Console.ReadLine();
			if (!Directory.Exists(putanja))
			{
				Console.WriteLine("Unesena putanja ne postoji");
			}
			else
			{
				var result = Directory.GetDirectories(putanja);
				Console.WriteLine( (from res in result orderby Path.GetDirectoryName(res) descending select res).FirstOrDefault());
			}
			
		}

		public void Automobili()
		{
			Console.WriteLine("Napravite klasu automobil. U konzolnom prozoru omogućite unos novih automobila. Nakon svakog novog unosa pitajte: 'Želite li upisati novi automobil (d)?' Svi ostali znakovi uvjetuju izlazak iz petlje. Nakon izlaska" +
				"iz petlje je na konzolnom prozoru potrebno ispisati sve modele automobila predane po modelu vozila uzlazno, ali samo one kojima je zapremnina veća od 1600 ccm.\n");

			Automobil auto1 = new Automobil();
			List<Automobil> listaAutomobila = new List<Automobil>();
			listaAutomobila.Add(auto1);
			auto1.Marka = Entry.String("Marka:");
			auto1.Model = Entry.String("Model:");
			auto1.Zapremnina = Entry.NaturalNumber("Zapremnina:");

			while (true)
			{
				Console.WriteLine("Zelite li upisati novi automobil (d)?");
				var odgovor = Console.ReadKey();
				if (odgovor.Key == ConsoleKey.D)
				{
					Automobil auto = new Automobil();
					Console.WriteLine("Unesi marku auta:");
					auto.Marka = Console.ReadLine();
					Console.WriteLine("Unesi Model auta: ");
					auto.Model = Console.ReadLine();
					Console.WriteLine("Unesi Zapremninu");
					auto.Zapremnina = int.Parse(Console.ReadLine());
					listaAutomobila.Add(auto);
				}
				else
				{
					break;
				}
			}

			var result = listaAutomobila.OrderBy(o => o.Model).Where(zapremnina => zapremnina.Zapremnina > 1600).ToList();

			foreach(Automobil auto in result)
			{
				Console.WriteLine(auto.Model);
			}
		}

		public void Brojevi()
		{
			Console.WriteLine("Napišite program koji traži unos prirodnih brojeva sve dok korisnik ne unese broj 0. Na konzolnom prozoru neka ispište broj parnih i broj neparnih brojeva, koristeći LINQ upite.\n");
			List<int> Brojevi = new List<int>();
			Brojevi = Entry.ListOfNaturalNumbers();
			

			var Parni = Brojevi.Where(br => br % 2 == 0).Count();
			var Neparni = Brojevi.Where(br => br % 2 != 0).Count();

			Console.WriteLine("Unešena su " + Parni + " parna broja");
			Console.WriteLine("Unešena su " + Neparni + " neparna broja");
		}

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Imena);
			Methods.Add(PrviDirektorij);
			Methods.Add(Automobili);
			Methods.Add(Brojevi);

			return Methods;
		}
	}

	class Automobil
	{
		public string Marka { get; set; }
		public string Model { get; set; }
		public int Zapremnina { get; set; }
	}
}
