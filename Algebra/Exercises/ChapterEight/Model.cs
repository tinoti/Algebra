using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.ChapterEight
{
	class Proizvod
	{
		public string Naziv { get; set; }
		public double Cijena { get; set; }
		public double Marza { get; set; }
		public double Porez { get; set; }

		public double MPC()
		{
			return (Cijena + Marza ) * Porez;
		}
	}

	class Automobil
	{
		public string MarkaAutomobila { get; set; }
		public double KS { get; set; }
		public double OsnovnaCijena { get; set; }

		public double IznosPoreza()
		{
			if(KS < 50)
			{
				return 1.05;
			}
			else if(KS > 50 && KS < 150)
			{
				return 1.1;
			}
			else
			{
				return 1.15;
			}
		}

		public double UkupnaCijena()
		{
			return OsnovnaCijena * IznosPoreza();
		}
	}

	class Zaposlenik
	{

		public Zaposlenik() { }

		public Zaposlenik(string Ime, string Prezime)
		{
			this.Ime = Ime;
			this.Prezime = Prezime;
		}

		public Zaposlenik(string Ime, string Prezime, string JMBG)
		{
			this.Ime = Ime;
			this.Prezime = Prezime;
			this.JMBG = JMBG;
		}

		public Zaposlenik(string Ime, string Prezime, string JMBG, int BrojBodova, double VrijednostBoda)
		{
			this.Ime = Ime;
			this.Prezime = Prezime;
			this.JMBG = JMBG;
			this.BrojBodova = BrojBodova;
			this.VrijednostBoda = VrijednostBoda;
		}

		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string JMBG { get; set; }
		public int BrojBodova { get; set; }
		public double VrijednostBoda { get; set; }
		

		public double Porez
		{
			get
			{
				double neto = NetoIzracunPlace();
				if(neto < 3000)
				{
					return neto * 0.06;
				}
				else if(neto < 6000)
				{
					return neto * 0.12;
				}
				else
				{
					return neto * 0.2;
				}
			}

		}


		public double NetoIzracunPlace()
		{
			return BrojBodova * VrijednostBoda;
		}

		public double BrutoIzracunPlace()
		{
			return NetoIzracunPlace() * Porez;
		}
	}

	class Static
	{
		private Static() { }

		public static double Zbroj(double broj1, double broj2)
		{
			return broj1 + broj2;
		}

		public static double Kub(double broj)
		{
			return Math.Pow(broj, 3);
		}

		public static double UdaljenostTocaka(double x1, double x2, double y1, double y2)
		{
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		}

		public static double CelzijFahrenheit(int stupnjevi)
		{
			return (9.0 / 5.0 * stupnjevi) + 32;
		}
	}

	class StaticIInstanca
	{
		public static void Prost(int broj)
		{
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

		public void Savrsen(int broj)
		{
			List<int> djelitelji = new List<int>();
			int result = 0;
			for (int i = broj - 1; i > 0; i--)
			{
				if (broj % i == 0)
				{
					djelitelji.Add(i);
				}
			}

			foreach (int br in djelitelji)
			{
				result += br;
			}

			if (result == broj)
			{
				Console.WriteLine("Broj je savršen.");
			}
			else
			{
				Console.WriteLine("Broj nije savršen.");
			}

			Prost(broj);
		}
	}


}
