﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algebra.Method;
using Algebra.Model;


namespace Algebra
{
	class Program
	{
		static void Main(string[] args)
		{

			Initialize Initialize = new Initialize();
			
			// INITIALIZATION
			List<Option> MainMenu, ExercisesMenu, ChapterFourOne, AfterExerciseMenu, ChapterFive, ChapterFiveOne, ChapterFiveTwo, ChapterFiveThree, ChapterSix, ChapterSixOne, ChapterSixTwo;
			Initialize.InitalizeMenues(out MainMenu, out ExercisesMenu, out ChapterFourOne, out ChapterFive, out ChapterFiveOne, out ChapterFiveTwo, out ChapterFiveThree, out ChapterSix, out ChapterSixOne, out ChapterSixTwo, out AfterExerciseMenu);


			// LINKING MENUES
			Initialize.LinkMenues(MainMenu, ExercisesMenu, ChapterFourOne, ChapterFive, ChapterFiveOne, ChapterFiveTwo, ChapterFiveThree, ChapterSix, ChapterSixOne, ChapterSixTwo);


			// LINKING METHODS
			Initialize.LinkFunctions(ChapterFourOne, ChapterFiveOne, ChapterFiveTwo, ChapterFiveThree, ChapterSixOne, ChapterSixTwo, AfterExerciseMenu);
			

			Initialize.Menu(MainMenu, 0);
						
		}
	}
}
