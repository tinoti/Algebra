using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.ChapterEight
{
	class ChapterEightTwoExercises
	{
		public void Static()
		{

		}

		public void StaticIInstanca()
		{

		}


		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(Static);
			Methods.Add(StaticIInstanca);

			return Methods;
		}
	}
}
