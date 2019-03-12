using System;
using System.Collections.Generic;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterTwelve
{
	class ChapterTwelveOneExercises
	{
		Entry Entry = new Entry();

		public void Rodjendan()
		{

			Osoba osoba = new Osoba(Entry.OneWord("Ime:"), Entry.OneWord("Prezime:"));

			DateTime DOB = DateTime.Parse(Entry.OneWord("Datum rodjenja:"));

			osoba.Rodjendan += new Osoba.RodjendanDelegat(RodjendanEvent);

			osoba.DatumRodjenja = DOB;
		}

		public void Stoperica()
		{
			Console.WriteLine("Napišite program koji će na pritisak neke tipke početi mjeriti vrijeme. Kad se slijedeći put pritisne neka tipka, program će ispisati koliko je vremena proteklo.\n");

			Entry.String("Pritisnite bilo koju tipku za početak mjerenja vremena.");
			DateTime d1 = DateTime.Now;

			Entry.String("Pritisnite bilo koju tipku za kraj.");
			DateTime d2 = DateTime.Now;

			TimeSpan ts = d2.Subtract(d1);

			Console.WriteLine("Proteklo je: " + ts);
		}


		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Rodjendan);
			Methods.Add(Stoperica);

			return Methods;
		}

		static void RodjendanEvent(object sender, EventArgs e)
		{
			Osoba osoba = (Osoba)sender;
			Console.WriteLine("SRETAN ROĐENDAN, " + osoba.Ime + "!");
		}
	}

	class Osoba
	{

		public enum Spol
		{
			Muski,
			Zenski
		}
		public string Ime { get; set; }
		public string Prezime { get; set; }
		
		public readonly int Starost;
		public Spol spol;

		public Osoba(string Ime, string Prezime)
		{
			this.Ime = Ime;
			this.Prezime = Prezime;
		}

		private DateTime datumRodjenja;

		public DateTime DatumRodjenja
		{
			get { return datumRodjenja; }
			set
			{
				datumRodjenja = value;

				if(datumRodjenja.ToString("dd MM") == DateTime.Now.ToString("dd MM"))
				{
					if(Rodjendan != null)
					{
						Rodjendan(this, new EventArgs());
					}
				}
			}
		}




		public delegate void RodjendanDelegat(Object sender, EventArgs e);
		public event RodjendanDelegat Rodjendan;


	}
}
