using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.Method
{
	class Helpers
	{
		public void Pitagorin(int a, int b) 
		{
			double c = Math.Sqrt((a * a) + (b * b));

			Console.WriteLine("Duljina hipotenuze je: " + c);
			
		}
	}
}
