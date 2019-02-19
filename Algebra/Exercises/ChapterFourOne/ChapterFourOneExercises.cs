using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra.Exercises.ChapterFourOneExercises
{
	class ChapterFourOneExercises
	{
		public void HelloWorld()
		{
			Console.WriteLine("ucitaj prvi broj");
			Console.ReadLine();
			Console.WriteLine("Ucitaj drugi broj");
			Console.ReadLine();
			Console.WriteLine("Tbroj je pet");
			//ExerciseLoop(HelloWorld);

		}

		public void HelloWorld2()
		{
			Console.WriteLine("two");
			//ExerciseLoop(HelloWorld2);


		}

		public void HelloWorld3()
		{
			Console.WriteLine("three");
			
		}

		public void EmptyFunction()
		{

		}

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(HelloWorld);
			Methods.Add(HelloWorld2);
			Methods.Add(HelloWorld3);
			Methods.Add(EmptyFunction);

			return Methods;
		}



	}
}
