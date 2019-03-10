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
}
