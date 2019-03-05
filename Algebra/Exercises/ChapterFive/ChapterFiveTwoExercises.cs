using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterFive
{
	class ChapterFiveTwoExercises
	{
		Entry Entry = new Entry();

		public void PozitivanIliNegativanBroj()
		{
			Console.WriteLine("Napišite program koji traži unos broja, te ispisuje je li broj pozitivan, negativan ili nula. \n");
			decimal Broj = Entry.DecimalNumber();
			if(Broj > 0)
			{
				Console.WriteLine("Unešeni broj je pozitivan.");
			}
			else if(Broj < 0)
			{
				Console.WriteLine("Unešeni broj je negativan");
			}
			else
			{
				Console.WriteLine("Unešeni broj je nula");
			}
		}

		public void Kalkulator()
		{
			Console.WriteLine("Napišite program - kalkulator s osnovnim računskim operacijama. Program traži unos 2 cijela broja, a zatim unos računske operacije. " +
				"Nakon toga ispisuje rezultat i omogućuje korisniku ponovno računanje ili prekid programa. Program treba ispisivati sve poruke za korisnika. \n");

			int PrviBroj = Entry.WholeNumber();
			int DrugiBroj = Entry.WholeNumber();

			while(true)
			{
				Console.WriteLine("Unesi računski operator");
				string RacunskiOperator = Console.ReadLine();
				if(RacunskiOperator == "+")
				{
					Console.WriteLine("Rezultat je: " + (PrviBroj + DrugiBroj));
					break;
				}
				else if(RacunskiOperator == "-")
				{
					Console.WriteLine("Rezultat je: " + (PrviBroj - DrugiBroj));
					break;
				}
				else if (RacunskiOperator == "*")
				{
					Console.WriteLine("Rezultat je: " + (PrviBroj * DrugiBroj));
					break;
				}
				else if (RacunskiOperator == "/")
				{
					Console.WriteLine("Rezultat je: " + ((decimal)PrviBroj / (decimal)DrugiBroj));
					break;
				}
				else
				{
					Console.WriteLine("Nisi unio ispravni operator, probaj ponovno");
				}
			}
		}

		public void VelikBroj()
		{
			Console.WriteLine("Napišite program koji traži unos broja i zatim: \n-ako broj ima više od 3 znamenke, ispisuje poruku 'Broj je velik' \n-inače ispisuje poruku 'Broj NIJE velik.' \n");

			int broj = Math.Abs(Entry.WholeNumber());
			int result = broj.ToString().Length;
			if(result > 3)
			{
				Console.WriteLine("Broj je velik.");
			}
			else
			{
				Console.WriteLine("Broj NIJE velik.");
			}
		}

		public void XZnamenkastiBroj()
		{
			Console.WriteLine("Napišite program koji traži unos broja i zatim ispisuje je li taj broj jednoznamenkast, dvoznamenkast, troznamenkast ili višeznamenkast. Program treba raditi i s negativnim brojevima!\n");

			int broj = Math.Abs(Entry.WholeNumber());
			int result = broj.ToString().Length;

			if(result == 1)
			{
				Console.WriteLine("Broj je jednoznamenkast.");
			}
			else if(result == 2)
			{
				Console.WriteLine("Broj je dvoznamenkast.");
			}
			else if(result == 3)
			{
				Console.WriteLine("Broj je troznamenkast");
			}
			else
			{
				Console.WriteLine("Broj je višeznamenkast");
			}
		}

		public void UIntervalu()
		{
			Console.WriteLine("Napišite program koji traži unos broja i ispisuje je li broj u intervalu [100, 200] ili ne");

			int broj = Entry.WholeNumber();
			if(broj <= 200 && broj >= 100)
			{
				Console.WriteLine("Broj je u zadanom intervalu.");
			}
			else
			{
				Console.WriteLine("Broj NIJE u zadanom intervalu");
			}
		}

		public void DobarBrojJedan()
		{
			Console.WriteLine("Napišite program koji traži unos broja i ispituje je li taj broj djeljiv s 5 ili s 3. Ako jest, ispisati 'Broj je dobar.', inače ispisati 'Broj NIJE dobar!' \n");
			int broj = Entry.WholeNumber();
			if(broj % 5 == 0 || broj %  3 == 0)
			{
				Console.WriteLine("Broj je dobar.");
			}
			else
			{
				Console.WriteLine("Broj NIJE dobar");
			}
		}

		public void DobarBrojDva()
		{
			Console.WriteLine("Napišite program koji traži unos broja i ispituje je li taj broj djeljiv sa 4 i nije manji od 100. Ako jest, ispisuje 'Broj je dobar.' Inače ispisuje 'Broj NIJE dobar!'. Programski kod treba osigurati od grešaka!\n");

			int broj = Entry.WholeNumber();
			if(broj % 4 == 0 && broj >= 100)
			{
				Console.WriteLine("Broj je dobar.");
			}
			else
			{
				Console.WriteLine("Broj NIJE dobar.");
			}
		}

		public void PrijestupnaGodina()
		{
			Console.WriteLine("Napišite program koji traži unos godine i ispisuje je li ta godina prijestupna ili ne (godina je prijestupna ako je djeljiva sa 4, nije djeljiva sa 100, osim ako je djeljiva sa 400).\n");
			int godina = Entry.Year();
			if((godina % 4 == 0 && godina % 100 != 0) || godina % 400 == 0)
			{
				Console.WriteLine("Godina je prijestupna");
			}
			else
			{
				Console.WriteLine("Godina nije prijestupna");
			}
		}

		public void CjelobrojnoDijeljenje()
		{
			Console.WriteLine("Napišite program koji traži unos broja te ispisuje je li taj broj paran ili neparan. te je li broj djeljiv s 3 ili koliki je ostatak pri dijeljenju s brojem 3. \n");

			var broj = Entry.WholeNumber();
			if(broj % 2 == 0)
			{
				Console.WriteLine("Broj je paran");
			}
			else
			{
				Console.WriteLine("Broj je neparan");
			}
			if(broj % 3 == 0)
			{
				Console.WriteLine("Broj je djeljiv s 3");
			}
			else
			{
				Console.WriteLine("Ostatak pri dijeljenju broja sa 3 je: " + ((decimal)broj % 3));
			}
		}


		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(PozitivanIliNegativanBroj);
			Methods.Add(Kalkulator);
			Methods.Add(VelikBroj);
			Methods.Add(XZnamenkastiBroj);
			Methods.Add(UIntervalu);
			Methods.Add(DobarBrojJedan);
			Methods.Add(DobarBrojDva);
			Methods.Add(PrijestupnaGodina);
			Methods.Add(CjelobrojnoDijeljenje);

			return Methods;
		}
	}
}
