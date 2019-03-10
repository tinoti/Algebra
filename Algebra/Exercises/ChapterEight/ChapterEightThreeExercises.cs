using System;
using System.Collections;
using System.Collections.Generic;
using Algebra.Exercises.Method;


namespace Algebra.Exercises.ChapterEight
{
	class ChapterEightThreeExercises
	{
		Entry Entry = new Entry();

		public void Vozila()
		{
			char unos = 'd';

			ArrayList vozila = new ArrayList();
			Automobili automobili = new Automobili();

			while(unos == 'd' || unos == 'D')
			{
				Console.WriteLine("Za unos automobila 1, za unos broda 2:");
				char odabir = Console.ReadKey(false).KeyChar;

				if(odabir == '1')
				{
					Automobil1 automobil = new Automobil1();

					automobil.Naziv = Entry.OneWord("Naziv:");
					automobil.Boja = Entry.OneWord("Boja:");
					automobil.KS = Entry.NaturalNumber("KS");
					automobil.CCM = (double)Entry.NaturalNumber("CCM:");

					vozila.Add(automobil);
					automobili.Add(automobil);
				}
				else if (odabir == '2')
				{
					Brod brod = new Brod();
					brod.NaPromjenuIstisnine += new Brod.NaPromjenuIstisnineDelegat(NaPromjenuIstisnine);

					brod.Naziv = Entry.OneWord("Naziv:");
					brod.Boja = Entry.OneWord("Boja:");
					brod.KS = Entry.NaturalNumber("KS");
					brod.Istisnina = (double)Entry.NaturalNumber("Istisnina:");

					vozila.Add(brod);
				}
				else
				{
					Console.WriteLine("Pogrešan odabir");
				}

				Console.WriteLine("Želiš li unositi još vozila (D/N)?");
				unos = Console.ReadKey().KeyChar;
			}

			Console.WriteLine("\nAutomobili:");
			foreach(Automobil1 automobil in automobili)
			{
				Console.WriteLine(automobil.ToString());
			}

			
			
		}

		public void Proizvod()
		{
			Proizvod1 proizvod = new Proizvod1();
			proizvod.NaIzracunCijene += new Proizvod1.NaIzracunCijeneDelegat(IzracunCijene);

			proizvod.Naziv = Entry.OneWord("Naziv:");
			proizvod.OsnovnaCijena = Entry.NaturalNumber("Osnovna cijena:");
			proizvod.Marza = (double) Entry.DecimalNumber("Marza");

			proizvod.IzracunajCijenu();
		}

		static void NaPromjenuIstisnine(object o, EventArgs e)
		{
			Brod brod = (Brod)o;
			Console.WriteLine("Dogodila se promjena istisnine.");
			Console.WriteLine("Nova istisnina: " + brod.Istisnina);
		}

		static void IzracunCijene(object o, EventArgs e)
		{
			Proizvod1 proizvod = (Proizvod1)o;
			Console.WriteLine("Izračunata je ukupna cijena proizvoda " + proizvod.Naziv);
		}


		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Vozila);
			Methods.Add(Proizvod);

			return Methods;
		}
	}
}
