using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterSeven
{
	class ChapterSevenTwoExercises
	{
		Entry Entry = new Entry();
		Helpers Helpers = new Helpers();

		public void Krug()
		{
			Console.WriteLine("Napišite program koji za uneseni radijus ispisuje opseg i površinu kruga. Za opseg i površinu koristite posebne funkcije. \n");

			int radius = Entry.NaturalNumber();

			Console.WriteLine("Opseg je: " + Helpers.Opseg(radius));
			Console.WriteLine("Povrsina je: " + Helpers.Povrsina(radius));
		}

		public void JedakokracanTrokut()
		{
			Console.WriteLine("Napišite program koji za unesene duljine kateta u funkciji računa površinu jednakokračnog trokuta i ispisuje ju na ekran.\n");

			int KatetaJedan = Entry.NaturalNumber("Unesi duljinu prve katete");
			int KatetaDva = Entry.NaturalNumber("Unesi duljinu druge katete");

			Console.WriteLine("Površina jednakokračnog trokuta je: " + Helpers.PovrsinaJednakokracnogTrokuta(KatetaJedan, KatetaDva));
		}

		public void KSuKW()
		{
			Console.WriteLine("Izradite funkciju koja pretvara KS u KW (1KS = 0,736 KW). \n");

			int KS = Entry.NaturalNumber("Unesi broj KS");
			Console.WriteLine(KS + "KS->" + (KS * 0.736) + "KW");
		}

		public void CelzijUFahrenheit()
		{
			Console.WriteLine("Izradite funkciju koja preračunava stupnjeve Celzijeve ljestvice u stupnjeme Fahrenheitove.\n");
			int C = Entry.WholeNumber("Unesite stupnjeve Celzijeve: ");
			double F = (9.0 / 5.0 * C) + 32;
			Console.WriteLine(C + "C -> " + F + " Fahrenheit");
		}

		public void Udaljenost()
		{
			Console.WriteLine("Izradite funkciju koja računa udaljenost između dvije točke P1(x1, y1) i P2(x2, y,2).\n");
			int x1 = Entry.NaturalNumber("Unesi x1:");
			int x2 = Entry.NaturalNumber("Unesi x2:");

			int y1 = Entry.NaturalNumber("Unesi y1:");
			int y2 = Entry.NaturalNumber("Unesi y2:");

			Console.WriteLine("Udaljenost između dvije točke je: " + Helpers.UdaljenostIzmeduDvijeTocke(x1, x2, y1, y2));
		}

		public void ProstBroj()
		{
			Console.WriteLine("Napišite program koji u funkciji ispituje je li uneseni prirodan broj prost ili složen (broj je prost ako je djeljiv samo s 1 i sa samim sobom). \n");
			int broj = Entry.NaturalNumber();
			int faktor = 1;
			while(true)
			{
				faktor++;
				if(broj % faktor == 0 && broj != faktor)
				{
					Console.WriteLine("Broj je složen!");
					break;
				}
				else if (broj == faktor)
				{
					Console.WriteLine("Broj je prost!");
					break;
				}
			}
		}

		public void ProstBrojPonovno()
		{
			Console.WriteLine("Napišite program koji u funkciji ispituje je li uneseni prirodan broj prost ili složen (broj je prost ako je djeljiv samo s 1 i sa samim sobom). \n");
			int broj = Entry.NaturalNumber();
			int faktor = 1;
			while (true)
			{
				faktor++;
				if (broj % faktor == 0 && broj != faktor)
				{
					Console.WriteLine("Broj je složen!");
					break;
				}
				else if (broj == faktor)
				{
					Console.WriteLine("Broj je prost!");
					break;
				}
			}
		}

		public void Faktorijel()
		{
			Console.WriteLine("Napišite program koji za uneseni prirodni broj računa faktorijel. \n");

			int broj = Entry.NaturalNumber();

			Console.WriteLine("Faktorijel unešenog broja je: " + Helpers.Faktorijel(broj));
		}

		public void Prosjek()
		{
			Console.WriteLine("Izradite funkcijui koja na temelju unesene prosječne ocjene riječima ispisuje poruku o uspjehu(npr. za unesenu prosječnu ocjenu 3,4 program ispisuje 'Prosjek je dobar.'). \n");
			decimal ProsjekOcjena = Entry.DecimalNumber("Unesi prosjek ocjena");

			Helpers.OcjenaRijecima(ProsjekOcjena);
		}

		public void UkupnaCijena()
		{
			Console.WriteLine("Napišite program koji traži unos ulazne cijene i tada računa ukupnu cijenu prema formuli.");
			decimal UlaznaCijena = Entry.DecimalNumber();
			double UkupnaCijena;
			double PDV = 1.25;

			if (UlaznaCijena < 100)
			{
				UkupnaCijena = Helpers.UkupnaCijena((double)UlaznaCijena, 5.5, (double)UlaznaCijena * 0.02, PDV);
			}
			else if (UlaznaCijena >= 100 && UlaznaCijena < 250)
			{
				UkupnaCijena = Helpers.UkupnaCijena((double)UlaznaCijena, 9.5, (double) UlaznaCijena * 0.03, PDV);
			}
			else if (UlaznaCijena >= 250 && UlaznaCijena < 500)
			{
				UkupnaCijena = Helpers.UkupnaCijena((double)UlaznaCijena, 15, (double)UlaznaCijena * 0.04, PDV);
			}
			else if (UlaznaCijena >= 500 && UlaznaCijena < 1000)
			{
				UkupnaCijena = Helpers.UkupnaCijena((double)UlaznaCijena, 25, (double)UlaznaCijena * 0.05, PDV);
			}
			else
			{
				UkupnaCijena = Helpers.UkupnaCijena((double)UlaznaCijena, 50, (double)UlaznaCijena * 0.10, PDV);
			}

			Console.WriteLine("Ukupna cijena je : " + UkupnaCijena);
		}

		public void ParniINeparni()
		{
			Console.WriteLine("Napišite program koji preko funckije traži unos brojeva sve dok se ne unese broj 0.  Napišite funckiju koja će iz unesenih brojeva izvući neparne brojeve, te funkciju koja" +
				"će iz unesenih brojeva izvući parne brojeve. Izradite funkciju koja će ispisati posebno neparne, a posebno parne brojeve.\n");

			List<int> Brojevi = Entry.ListOfNaturalNumbers();

			Helpers.IspisiListuBrojeva(Helpers.IzvuciNeparneBrojeveIzListe(Brojevi), "Neparni brojevi su: ");

			Helpers.IspisiListuBrojeva(Helpers.IzvuciParneBrojeveIzListe(Brojevi), "Parni brojevi su: ");

		}

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Krug);
			Methods.Add(JedakokracanTrokut);
			Methods.Add(KSuKW);
			Methods.Add(CelzijUFahrenheit);
			Methods.Add(Udaljenost);
			Methods.Add(ProstBroj);
			Methods.Add(ProstBrojPonovno);
			Methods.Add(Faktorijel);
			Methods.Add(Prosjek);
			Methods.Add(UkupnaCijena);
			Methods.Add(ParniINeparni);


			return Methods;
		}
	}
}
