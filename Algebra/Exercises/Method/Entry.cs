using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.Method
{
	class Entry
	{
		public int WholeNumber()
		{
			int number;

			while (true)
			{
				Console.WriteLine("Unesi broj:");
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
	}
}
