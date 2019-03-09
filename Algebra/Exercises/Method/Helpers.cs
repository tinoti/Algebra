using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.Method
{
	class Helpers
	{
		public double Pitagorin(int a, int b) 
		{
			return Math.Sqrt((a * a) + (b * b));
			
		}

		public double Opseg(int radius)
		{
			return 2 * radius * Math.PI;
		}

		public double Povrsina(int radius)
		{
			return radius * radius * Math.PI;
		}

		public double PovrsinaJednakokracnogTrokuta(int a, int b)
		{
			return (a * b) / 2;
		}

		public double UdaljenostIzmeduDvijeTocke(int x1, int x2, int y1, int y2)
		{
			return Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) );
		}

		public int Faktorijel(int n)
		{
			int result = 1;
			for (int i = 1; i <= n; i++)
			{
				result *= i;
			}
			return result;
		}

		public void OcjenaRijecima(decimal ocjena)
		{
			if ((float)ocjena < 1.5)
			{
				Console.WriteLine("Uspjeh je nedovoljan.");
			}
			else if((float)ocjena < 2.5)
			{
				Console.WriteLine("Uspjeh je dovoljan.");
			}
			else if((float) ocjena < 3.5)
			{
				Console.WriteLine("Uspjeh je dobar.");
			}
			else if((float) ocjena < 4.5)
			{
				Console.WriteLine("Uspjeh je vrlo dobar.");
			}
			else
			{
				Console.WriteLine("Uspjeh je odličan.");
			}
		}

		public double UkupnaCijena(double UlaznaCijena, double Marza, double Porez, double PDV)
		{
			return (UlaznaCijena + Marza + Porez) * PDV;
		}

		public List<int> IzvuciParneBrojeveIzListe(List<int> Brojevi)
		{
			List<int> ParniBrojevi = new List<int>();

			foreach(int broj in Brojevi)
			{
				if (broj % 2 == 0)
				{
					ParniBrojevi.Add(broj);
				}
			}
			return ParniBrojevi;
		}

		public List<int> IzvuciNeparneBrojeveIzListe(List<int> Brojevi)
		{
			List<int> NeparniBrojevi = new List<int>();

			foreach (int broj in Brojevi)
			{
				if (broj % 2 != 0)
				{
					NeparniBrojevi.Add(broj);
				}
			}
			return NeparniBrojevi;
		}

		public void IspisiListuBrojeva(List<int> List, string text)
		{
			Console.WriteLine(text);
			foreach(int broj in List)
			{
				Console.WriteLine(broj);
			}
		}
	}
}
