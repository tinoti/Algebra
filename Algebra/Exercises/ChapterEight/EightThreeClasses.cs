using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.ChapterEight
{
	class Vozilo
	{
		public string Naziv { get; set; }
		public string Boja { get; set; }
		public int KS { get; set; }

		public double KSToKW()
		{
			return KS * 0.736;
		}
	}

	class Automobil1 : Vozilo
	{
		public double CCM { get; set; }

		public void ToString(string Naziv, int KS)
		{
			Console.WriteLine(Naziv + ", " + KS);
		}
		

		
	}

	class Brod : Vozilo
	{
		public delegate void NaPromjenuIstisnineDelegat(object o, EventArgs e);
		public event NaPromjenuIstisnineDelegat NaPromjenuIstisnine;

		private double istisnina;

		public double Istisnina
		{
			get { return istisnina; }
			set
			{
				istisnina = value;
				if(NaPromjenuIstisnine != null)
				{
					NaPromjenuIstisnine(this, new EventArgs());
				}
			}
		}


	}

	class Automobili : System.Collections.CollectionBase
	{
		public int Add(Automobil1 automobil)
		{
			return InnerList.Add(automobil);
		}

		public void Remove(Automobil1 automobil)
		{
			InnerList.Remove(automobil);
		}

		public Automobil1 this[int index]
		{
			get
			{
				return (Automobil1)InnerList[index];
			}
		}
	}

	class Proizvod1
	{
		public delegate void NaIzracunCijeneDelegat(object sender, EventArgs e);
		public event NaIzracunCijeneDelegat NaIzracunCijene;

		public string Naziv { get; set; }
		public double OsnovnaCijena { get; set; }
		private double marza = 0;

		public double Marza
		{
			get { return marza = 0; }
			set
			{
				while (true)
				{
					if (value < 0 || value > 1)
					{
						Console.WriteLine("Vrijednost marže može biti samo postotak(broj iz intervala [0, 1], probaj ponovno.)");
						value = double.Parse(Console.ReadLine());
					}
					else
					{
						marza = value;
						break;
					}
				}
				
			}
		}

		public double IzracunajCijenu()
		{
			if(NaIzracunCijene != null)
			{
				NaIzracunCijene(this, new EventArgs());
			}

			return OsnovnaCijena + OsnovnaCijena * Marza;
		}

	}
}
