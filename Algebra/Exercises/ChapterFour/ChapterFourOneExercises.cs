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
			Console.WriteLine("Napišite program koji na konzoli (ekranu) ispisuje 'Hello World!' \n");

			Console.WriteLine("Hello World!");

		}

		public void IspisBrojeva()
		{
			Console.WriteLine("Napišite program koji na konzoli ispisuje brojeve 1,2 i 3, svaki u novi red.\n");

			Console.WriteLine("1");
			Console.WriteLine("2");
			Console.WriteLine("3");


		}

		public void IspisLedistaIVrelista()
		{
			Console.WriteLine("Napišite program koji će ispisivati temperaturu ledišta i vrelišta vode, svaku u novi red. \n");
			Console.WriteLine("Temperatura ledišta vode je 0C");
			Console.WriteLine("Temperatura vrelišta vode je 100C");
			
		}

		public void EmptyFunction()
		{

		}

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(HelloWorld);
			Methods.Add(IspisBrojeva);
			Methods.Add(IspisLedistaIVrelista);
			Methods.Add(EmptyFunction);

			return Methods;
		}



	}
}
