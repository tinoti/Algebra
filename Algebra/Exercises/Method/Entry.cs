using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.Method
{
	class Entry
	{
		public int Number()
		{
			Console.WriteLine("Unesi broj:");
			return int.Parse(Console.ReadLine());
		}
	}
}
