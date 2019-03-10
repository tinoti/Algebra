using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;

namespace Algebra.Exercises.ChapterEight
{
	class ChapterEightTwoExercises
	{
		Entry Entry = new Entry();
		public void Static()
		{
			Console.WriteLine("Static cannot be instantiated due to it's protection level!");
			//Static Static = new Static();

		}

		public void StaticIInstanca()
		{
			StaticIInstanca Static = new StaticIInstanca();

			int broj = Entry.NaturalNumber();
			Static.Savrsen(broj);
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
