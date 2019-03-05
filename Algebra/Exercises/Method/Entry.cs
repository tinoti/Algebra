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
	}
}
