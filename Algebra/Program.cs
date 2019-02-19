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



			// INITIALIZATION
			List<Option> MainMenu, ExercisesMenu, ChapterFour, ChapterFourOne, AfterExerciseMenu;
			Initialize.InitalizeMenues(out MainMenu, out ExercisesMenu, out ChapterFour, out ChapterFourOne, out AfterExerciseMenu, Paths);


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
