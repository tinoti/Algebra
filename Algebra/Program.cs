using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Method;
using Algebra.Model;
using Algebra.Exercises.ChapterFourOne;

namespace Algebra
{
	class Program
	{
		static void Main(string[] args)
		{



			Paths Paths = new Paths();
			Initialize Initialize = new Initialize();
			Navigation Navigation = new Navigation();
			ChapterFourOne chapterFourOne = new ChapterFourOne();


			////////// INITIALIZATION : initialize all the menues and sub menues ///////////////

			// Main menu 
			List<Option> MainMenu = new List<Option>();
			MainMenu = Initialize.FillWithMenuOptions(Paths.MainMenu());

			// Exercises menu 
			List<Option> ExercisesMenu = new List<Option>();
			ExercisesMenu = Initialize.FillWithMenuOptions(Paths.ExercisesMenu());

			//4. Poglavlje: VISUAL STUDIO .net 4.5 menu
			List<Option> ChapterFour = new List<Option>();
			ChapterFour = Initialize.FillWithMenuOptions(Paths.ChapterFour());
			//4.1 Uvod
			List<Option> ChapterFourOne = new List<Option>();
			ChapterFourOne = Initialize.FillWithMenuOptions(Paths.ChapterFourOne());

			List<Option> AfterExerciseMenu = new List<Option>();
			AfterExerciseMenu = Initialize.FillWithMenuOptions(Paths.AfterExerciseMenu());

			//5. Poglavlje: OSNOVNI TIPOVI PODATAKA menu
			





			MainMenu[0].SubMenu = ExercisesMenu;
			ExercisesMenu[0].SubMenu = ChapterFourOne;




			List<Action> ListOfFunctions = chapterFourOne.ReturnListOfFunctions();
			for (int i = 0; i < ChapterFourOne.Count; i++)
			{

				ChapterFourOne[i].Method = ListOfFunctions[i];
				ChapterFourOne[i].SubMenu = AfterExerciseMenu;
				ChapterFourOne[i].NoSubMenu = true;
			}



			Console.WriteLine("\n\n\n");


			Initialize.Menu(MainMenu, 0);
						
		}
	}
}
