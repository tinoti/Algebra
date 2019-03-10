using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.Method
{
	class Entry
	{
		//Loops until user enters a whole number
		public int WholeNumber()
		{
			int number;

			while (true)
			{
				Console.WriteLine("Unesi cijeli broj:");
				var EnteredValue = Console.ReadLine();
				if (int.TryParse(EnteredValue, out number))
				{
					number = int.Parse(EnteredValue);
					break;
				}
				else
				{
					Console.WriteLine("Invalid entry, try again.");
				}

			}

			return number; 
		}

		//Overload that allows to enter manual text
		public int WholeNumber(string text)
		{
			int number;

			while (true)
			{
				Console.WriteLine(text);
				var EnteredValue = Console.ReadLine();
				if (int.TryParse(EnteredValue, out number))
				{
					number = int.Parse(EnteredValue);
					break;
				}
				else
				{
					Console.WriteLine("Invalid entry, try again.");
				}

			}

			return number;
		}

		//Loops until user enters a natural number or zero
		public int NaturalNumberOrZero()
		{
			int number;

			while (true)
			{
				Console.WriteLine("Unesi prirodni broj ili 0 za kraj:");
				var EnteredValue = Console.ReadLine();
				if (int.TryParse(EnteredValue, out number))
				{
					if(number >= 0)
					{
						number = int.Parse(EnteredValue);
						break;
					}
					else
					{
						Console.WriteLine("Invalid entry, try again.");
					}
					
				}
				else
				{
					Console.WriteLine("Invalid entry, try again.");
				}

			}

			return number;
		}

		//Loops until user enters a natural number
		public int NaturalNumber()
		{
			int number;

			while (true)
			{
				Console.WriteLine("Unesi prirodni broj:");
				var EnteredValue = Console.ReadLine();
				if (int.TryParse(EnteredValue, out number))
				{
					if (number > 0)
					{
						number = int.Parse(EnteredValue);
						break;
					}
					else
					{
						Console.WriteLine("Invalid entry, try again.");
					}

				}
				else
				{
					Console.WriteLine("Invalid entry, try again.");
				}

			}

			return number;
		}

		//Override that allows to enter manual text
		public int NaturalNumber(string text)
		{
			int number;

			while (true)
			{
				Console.WriteLine(text);
				var EnteredValue = Console.ReadLine();
				if (int.TryParse(EnteredValue, out number))
				{
					if (number > 0)
					{
						number = int.Parse(EnteredValue);
						break;
					}
					else
					{
						Console.WriteLine("Invalid entry, try again.");
					}

				}
				else
				{
					Console.WriteLine("Invalid entry, try again.");
				}

			}

			return number;
		}

		//Loops until user enters a number
		public decimal DecimalNumber()
		{
			decimal number;

			while (true)
			{
				Console.WriteLine("Unesi broj:");
				var EnteredValue = Console.ReadLine();
				if (decimal.TryParse(EnteredValue, out number))
				{
					number = decimal.Parse(EnteredValue);
					break;
				}
				else
				{
					Console.WriteLine("Invalid entry, try again.");
				}

			}

			return number;
		}

		//Overload that allows to enter manual text
		public decimal DecimalNumber(string text)
		{
			decimal number;

			while (true)
			{
				Console.WriteLine(text);
				var EnteredValue = Console.ReadLine();
				if (decimal.TryParse(EnteredValue, out number))
				{
					number = decimal.Parse(EnteredValue);
					break;
				}
				else
				{
					Console.WriteLine("Invalid entry, try again.");
				}

			}

			return number;
		}

		//Loops until user enters a valid year
		public int Year()
		{
			int year;

			while (true)
			{
				Console.WriteLine("Unesi godinu:");
				var EnteredValue = Console.ReadLine();
				if (int.TryParse(EnteredValue, out year))
				{
					int EnteredValue1 = int.Parse(EnteredValue);
					if(EnteredValue1 < 0)
					{
						Console.WriteLine("Invalid entry, try again.");
					}
					else
					{
						year = EnteredValue1;
						break;
					}
				}
				else
				{
					Console.WriteLine("Invalid entry, try again.");
				}

			}
			return year;

		}

		//Loops until user enters a valid year
		public int Grade()
		{
			
			int ocjena;
			while(true)
			{
				ocjena = WholeNumber("Unesi ocjenu: ");
				if(ocjena < 1 || ocjena > 5)
				{
					Console.WriteLine("Krivi unos, probaj ponovno");
				}
				else
				{
					return ocjena;
				}
			}
		}

		//Returns a list with X  natural numbers in it
		public List<int> ListOfNaturalNumbers(int x)
		{
			List<int> NumbersList = new List<int>();
			for (int i = 1; i <= x; i++)
			{
				NumbersList.Add(NaturalNumber("Upišite " + i + ".  prirodni broj: "));
			}

			return NumbersList;
		}

		//Overload for unlimited entry of natural numbers, enter zero to exit
		public List<int> ListOfNaturalNumbers()
		{
			int broj;
			List<int> NumbersList = new List<int>();
			while (true)
			{
				broj = NaturalNumberOrZero();
				if (broj != 0)
				{
					NumbersList.Add(broj);
				}
				else
				{
					break;
				}
			}

			return NumbersList;
		}



	}
}
