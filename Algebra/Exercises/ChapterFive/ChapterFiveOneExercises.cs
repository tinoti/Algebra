using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Exercises.Method;


namespace Algebra.Exercises.ChapterFive
{
	class ChapterFiveOneExercises
	{
		Entry Entry = new Entry();

		public void ZbrojIRazlika()
		{
			var PrviBroj = Entry.Number();
			var DrugiBroj = Entry.Number();
		}


		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(ZbrojIRazlika);
			//Methods.Add(IspisBrojeva);
			//Methods.Add(IspisLedistaIVrelista);
			//Methods.Add(EmptyFunction);

			return Methods;
		}

	}
}
