using System;
using System.Collections.Generic;
using Algebra.Method;
using Algebra.Model;


namespace Algebra
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;

			Initialize Initialize = new Initialize();
			
			// INITIALIZATION
			List<Option> MainMenu, ExercisesMenu, ChapterFourOne, AfterExerciseMenu, ChapterFive, ChapterFiveOne, ChapterFiveTwo, ChapterFiveThree, ChapterSix, ChapterSixOne, ChapterSixTwo, ChapterSeven, ChapterSevenOne, ChapterSevenTwo, ChapterEight, ChapterEightOne, ChapterEightTwo, ChapterEightThree, ChapterNine, ChapterTen, ChapterEleven, ChapterTwelve;
			Initialize.InitalizeMenues(out MainMenu, out ExercisesMenu, out ChapterFourOne, out ChapterFive, out ChapterFiveOne, out ChapterFiveTwo, out ChapterFiveThree, out ChapterSix, out ChapterSixOne, out ChapterSixTwo, out ChapterSeven, out ChapterSevenOne, out ChapterSevenTwo, out ChapterEight, out ChapterEightOne, out ChapterEightTwo, out ChapterEightThree, out ChapterNine, out ChapterTen, out ChapterEleven, out ChapterTwelve, out AfterExerciseMenu);


			// LINKING MENUES
			Initialize.LinkMenues(MainMenu, ExercisesMenu, ChapterFourOne, ChapterFive, ChapterFiveOne, ChapterFiveTwo, ChapterFiveThree, ChapterSix, ChapterSixOne, ChapterSixTwo, ChapterSeven, ChapterSevenOne, ChapterSevenTwo, ChapterEight, ChapterEightOne, ChapterEightTwo, ChapterEightThree, ChapterNine, ChapterTen, ChapterEleven, ChapterTwelve);


			// LINKING METHODS
			Initialize.LinkFunctions(MainMenu, ChapterFourOne, ChapterFiveOne, ChapterFiveTwo, ChapterFiveThree, ChapterSixOne, ChapterSixTwo, ChapterSevenOne, ChapterSevenTwo, ChapterEightOne, ChapterEightTwo, ChapterEightThree, ChapterNine, ChapterTen, ChapterEleven, ChapterTwelve, AfterExerciseMenu);

			Initialize.Menu(MainMenu, 0);
						
		}
	}
}
