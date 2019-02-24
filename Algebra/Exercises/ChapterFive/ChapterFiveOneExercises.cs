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
			Console.WriteLine("Napišite program koji traži unos 2 cijela broja i prikazuje na ekranu njihov zbroj te razliku. \n");
			int PrviBroj = Entry.WholeNumber();
			int DrugiBroj = Entry.WholeNumber();

			Console.WriteLine("Zbroj dvaju unešena broja je: " + (PrviBroj + DrugiBroj));
			Console.WriteLine("Razlika dvaju unešena broja je: " + (PrviBroj - DrugiBroj));

			
		}

		public void UmnozakIKvocijent()
		{
			Console.WriteLine("Napišite program koji traži unos 2 cijela broja i prikazuje na ekranu njihov umnožak i kvocijent. \n");
			int PrviBroj = Entry.WholeNumber();
			int DrugiBroj = Entry.WholeNumber();

			Console.WriteLine("Umnožak dvaju unešenih brojeva je: " + (PrviBroj * DrugiBroj));
			Console.WriteLine("Kvocijent dvaju unešenih brojeva je: " + ((decimal)PrviBroj / (decimal)DrugiBroj));
		}
		

		public List<Action> ReturnListOfFunctions()
		{
			List<Action> Methods = new List<Action>();
			Methods.Add(ZbrojIRazlika);
			Methods.Add(UmnozakIKvocijent);

			return Methods;
		}

	}
}
