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

			//TO DO:
			// refacture below code to a InitializeMenues function that initializes all menues in the data menues folder (returns to a single list here),
			// and LinkMenues() that links all the menues and sub menues


			Paths Paths = new Paths();
			Initialize Initialize = new Initialize();
			Navigation Navigation = new Navigation();
			ChapterFourOne chapterFourOne = new ChapterFourOne();


			////////// INITIALIZATION : initialize all the menues and sub menues ///////////////

			List<Option> MainMenu, ExercisesMenu, ChapterFourOne, AfterExerciseMenu;
			NewMethod(Paths, Initialize, out MainMenu, out ExercisesMenu, out ChapterFourOne, out AfterExerciseMenu);

			MainMenu[0].SubMenu = ExercisesMenu;
			ExercisesMenu[0].SubMenu = ChapterFourOne;




			List<Action> ListOfFunctions = chapterFourOne.ReturnListOfFunctions();
			for (int i = 0; i < ChapterFourOne.Count; i++)
			{

				ChapterFourOne[i].Method = ListOfFunctions[i];
				ChapterFourOne[i].SubMenu = AfterExerciseMenu;
				ChapterFourOne[i].NoSubMenu = true;
			}






			Initialize.Menu(MainMenu, 0);

		}

		private static void NewMethod(Paths Paths, Initialize Initialize, out List<Option> MainMenu, out List<Option> ExercisesMenu, out List<Option> ChapterFourOne, out List<Option> AfterExerciseMenu)
		{
			// Main menu 
			MainMenu = new List<Option>();
			MainMenu = Initialize.FillWithMenuOptions(Paths.MainMenu());

			// Exercises menu 
			ExercisesMenu = new List<Option>();
			ExercisesMenu = Initialize.FillWithMenuOptions(Paths.ExercisesMenu());

			//4. Poglavlje: VISUAL STUDIO .net 4.5 menu
			List<Option> ChapterFour = new List<Option>();
			ChapterFour = Initialize.FillWithMenuOptions(Paths.ChapterFour());
			//4.1 Uvod
			ChapterFourOne = new List<Option>();
			ChapterFourOne = Initialize.FillWithMenuOptions(Paths.ChapterFourOne());

			AfterExerciseMenu = new List<Option>();
			AfterExerciseMenu = Initialize.FillWithMenuOptions(Paths.AfterExerciseMenu());

			//5. Poglavlje: OSNOVNI TIPOVI PODATAKA menu
		}
	}
}
