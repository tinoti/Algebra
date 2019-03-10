using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.ChapterEight
{
	class ChapterEightThreeExercises
	{
		public void Vozila()
		{

		}

		public void Proizvod()
		{

		}


		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Vozila);
			Methods.Add(Proizvod);

			return Methods;
		}
	}
}
